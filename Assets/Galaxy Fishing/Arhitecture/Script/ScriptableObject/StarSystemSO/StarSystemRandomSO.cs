using UnityEngine;

[CreateAssetMenu(fileName = "newStarSystemParam", menuName = "StarSystem/Create new StarSystemRandom", order = 51)]

public class StarSystemRandomSO : ScriptableObject
{
    [SerializeField] private StarRandomSO _starParam;
    [SerializeField] private PlanetRandomSO _planetParam;
    [SerializeField] private string _tag = "deafault";

    public StarRandomSO StarParam { get => _starParam; set => _starParam = value; }
    public PlanetRandomSO PlanetParam { get => _planetParam; set => _planetParam = value; }
    public string Tag { get => _tag; set => _tag = value; }
}