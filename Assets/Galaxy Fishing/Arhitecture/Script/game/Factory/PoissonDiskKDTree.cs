using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PoissonDiskKDTree : MonoBehaviour
{
    [SerializeField] private GenerateGalaxySO _param;
    [SerializeField] private int _strarsSpawnCount = 5000;
    [SerializeField] private int _seed;
    [SerializeField] private GameObject _starSystemPrefab;

    private List<Vector2> points;

    async void Start()
    {
        await CreateGalaxy();
    }

    private async Task CreateGalaxy()
    {
        Random.InitState(_seed);
        float regionSize = Random.Range(_param.MinDiameterGalaxy, _param.MaxDiameterGalaxy);
        Vector2 regionSizeVector2 = new Vector2(regionSize, regionSize);
        points = GeneratePoints(_param.MinDistanceBetweenStars, _param.MaxDistanceBetweenStars, regionSizeVector2, _strarsSpawnCount);
        points = await GetPoitsInCircle(points, regionSizeVector2);

        GameObject galaxy = new GameObject($"Galaxy {_seed}");
        galaxy.isStatic = true;

        GenerateSpheresAsync(regionSize, galaxy);
    }

    private void CreateSphers(float regionSize, GameObject galaxy)
    {

        foreach (Vector2 point in points)
        {
            Vector3 position = new Vector3(point.x - (regionSize / 2), 0, point.y - (regionSize / 2));
            GameObject sphere = Instantiate(_starSystemPrefab, position, Quaternion.identity);
            sphere.transform.parent = galaxy.transform;

        }
    }

    private async void GenerateSpheresAsync(float regionSize, GameObject galaxy)
    {
        List<Task> tasks = new List<Task>();

        foreach (Vector2 point in points)
        {
            tasks.Add(GenerateSphereAsync(point, galaxy.transform, regionSize));
        }
        await Task.WhenAll(tasks);
    }

    private async Task GenerateSphereAsync(Vector2 point, Transform galaxy, float regionSize)
    {
        await Task.Yield();

        Vector3 position = new Vector3(point.x - (regionSize / 2), 0, point.y - (regionSize / 2));
        GameObject sphere = Instantiate(_starSystemPrefab, position, Quaternion.identity);
        sphere.transform.parent = galaxy.transform;

        MakeStatic(sphere);

        //sphere.isStatic = true;

    }

    private void MakeStatic(GameObject obj)
    {
        obj.isStatic = true;

        foreach(Transform child in obj.transform)
        {
            MakeStatic(child.gameObject);
        }
    }

    private async Task<List<Vector2>> GetPoitsInCircle(List<Vector2> points, Vector2 regionSize)
    {
        //JobCircle jobCircle = new JobCircle()
        //{
        //    //Points = points,
        //    CircleCenter = regionSize / 2,
        //    CircleRadius = regionSize.x / 2,
        //    NewPointsInCircle = new NativeList<Vector2>

        //};

        //JobHandle jobHandle = JobCircle.S

        List<Vector2> result = new List<Vector2>();
        foreach (Vector2 point in points)
        {
            if (Vector2.Distance(point, regionSize / 2) <= regionSize.x / 2)
            {
                result.Add(point);
            }
        }
        await Task.Yield();
        return result;
    }


    private List<Vector2> GeneratePoints(float minRadius, float maxRadius, Vector2 regionSize, int targetPointCount)
    {
        List<Vector2> points = new List<Vector2>();
        KDTree tree = new KDTree();

        float cellSize = minRadius / Mathf.Sqrt(2);
        Vector2 regionCenter = regionSize / 2;
        List<Vector2> spawnPoints = new List<Vector2> { regionCenter };

        while (spawnPoints.Count > 0 && points.Count < targetPointCount)
        {
            int spawnIndex = Random.Range(0, spawnPoints.Count);
            Vector2 spawnCenter = spawnPoints[spawnIndex];
            bool candidateAccepted = false;

            for (int i = 0; i < 30; i++)
            {
                float angle = Random.Range(0f, Mathf.PI * 2);
                float distance = Random.Range(minRadius, maxRadius);
                Vector2 dir = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle));
                Vector2 candidate = spawnCenter + dir * distance;

                if (IsValid(candidate, regionSize, minRadius, maxRadius, tree))
                {
                    points.Add(candidate);
                    tree.AddPoint(candidate);
                    spawnPoints.Add(candidate);
                    candidateAccepted = true;
                    break;
                }
            }

            if (!candidateAccepted)
            {
                spawnPoints.RemoveAt(spawnIndex);
            }
        }
        return points;
    }

    bool IsValid(Vector2 candidate, Vector2 sampleRegionSize, float minRadius, float maxRadius, KDTree tree)
    {
        if (candidate.x >= 0 && candidate.x < sampleRegionSize.x && candidate.y >= 0 && candidate.y < sampleRegionSize.y)
        {
            List<Vector2> neighbors = tree.RangeSearch(candidate, maxRadius);
            foreach (Vector2 neighbor in neighbors)
            {
                if (Vector2.Distance(neighbor, candidate) < minRadius)
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    public class KDTree
    {
        private KDTreeNode root;

        public void AddPoint(Vector2 point)
        {
            root = AddPoint(root, point, 0);
        }

        private KDTreeNode AddPoint(KDTreeNode node, Vector2 point, int depth)
        {
            if (node == null)
            {
                return new KDTreeNode(point);
            }

            int axis = depth % 2;
            if (axis == 0)
            {
                if (point.x < node.Point.x)
                {
                    node.Left = AddPoint(node.Left, point, depth + 1);
                }
                else
                {
                    node.Right = AddPoint(node.Right, point, depth + 1);
                }
            }
            else
            {
                if (point.y < node.Point.y)
                {
                    node.Left = AddPoint(node.Left, point, depth + 1);
                }
                else
                {
                    node.Right = AddPoint(node.Right, point, depth + 1);
                }
            }

            return node;
        }

        public List<Vector2> RangeSearch(Vector2 point, float range)
        {
            List<Vector2> results = new List<Vector2>();
            RangeSearch(root, point, range, 0, results);
            return results;
        }

        private void RangeSearch(KDTreeNode node, Vector2 point, float range, int depth, List<Vector2> results)
        {
            if (node == null) return;

            if (Vector2.Distance(node.Point, point) <= range)
            {
                results.Add(node.Point);
            }

            int axis = depth % 2;
            float diff = (axis == 0) ? point.x - node.Point.x : point.y - node.Point.y;

            if (diff < 0)
            {
                RangeSearch(node.Left, point, range, depth + 1, results);
                if (diff * diff <= range * range)
                {
                    RangeSearch(node.Right, point, range, depth + 1, results);
                }
            }
            else
            {
                RangeSearch(node.Right, point, range, depth + 1, results);
                if (diff * diff <= range * range)
                {
                    RangeSearch(node.Left, point, range, depth + 1, results);
                }
            }
        }

        public class KDTreeNode
        {
            public Vector2 Point;
            public KDTreeNode Left;
            public KDTreeNode Right;

            public KDTreeNode(Vector2 point)
            {
                this.Point = point;
                this.Left = null;
                this.Right = null;
            }
        }
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (!_starSystemPrefab.TryGetComponent<StarSystem>(out StarSystem starSystem))
        {
            Debug.LogError("Prefab has not starSystem component", this);
            _starSystemPrefab = null;
        }
    } 
#endif
}
