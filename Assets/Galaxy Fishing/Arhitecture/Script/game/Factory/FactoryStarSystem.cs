using UnityEngine;
public class FactoryStarSystem : Singleton<FactoryStarSystem>
{
    [SerializeField] private FactoryStarSystemSO _factoryParam;

    public StarSystem GetOnlyStarSystem(int id)
    {
        Random.InitState(id);
        return CreateOnlyStarSystem(id);
    }
    public StarSystem GetAllStarSystem(int id)
    {

    }

    private StarSystem CreateOnlyStarSystem(int id)
    {
        StarFactory.Instance.GetStar(id, )

        return null;
    }
}