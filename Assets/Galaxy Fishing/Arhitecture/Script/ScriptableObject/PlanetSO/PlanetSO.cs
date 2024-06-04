using UnityEngine;

[CreateAssetMenu(fileName = "Planet", menuName = "Planet/Planets/Create new Planet", order = 51)]
public class PlanetSO : AbstractPlanetSO
{
    //[SerializeField] private Transform OrbitCenter;
    //[SerializeField] private int OrbitDistance;

    //[SerializeField] private PlanetZones PlanetZones;
    //[SerializeField] private List<Planet> Satellites;

    //[SerializeField] private int Gas;
    //[SerializeField] private int Water;
    //[SerializeField] private int Ground;
    //[SerializeField] private int Metal;

    [Header("Satellites")]
    [SerializeField] private PlanetSO[] _satellites;
    [Space]
    [SerializeField] private int _orbitDistance = 66;

    [Header("Param")]
    [SerializeField] private int _gas = 20;
    [SerializeField] private int _water = 200;
    [SerializeField] private int _ground = 500;
    [SerializeField] private int _metal = 150;

    [Header("Colors")]
    [SerializeField] private ColorSO[] _gasColor;
    [SerializeField] private ColorSO[] _waterColor;
    [SerializeField] private ColorSO[] _groundColor;
    [SerializeField] private ColorSO[] _metalColor;
}
