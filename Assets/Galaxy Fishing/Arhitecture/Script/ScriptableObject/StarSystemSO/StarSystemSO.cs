using UnityEngine;

[CreateAssetMenu(fileName = "newStarSystemParam", menuName = "StarSystem/Create new StarSystem", order = 51)]
public class StarSystemSO : ScriptableObject
{
    [SerializeField] private StarSO _star;

    [SerializeField] private AbstractPlanet[] _planets;

    [SerializeField] private string _tag = "Not Random";

    public StarSO Star { get => _star; set => _star = value; }
    public AbstractPlanet[] Planets { get => _planets; set => _planets = value; }
    public string Tag { get => _tag; set => _tag = value; }
}