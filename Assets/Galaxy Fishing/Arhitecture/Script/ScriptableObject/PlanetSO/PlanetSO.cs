using UnityEngine;

[CreateAssetMenu(fileName = "Planet", menuName = "Planet/Planets/Create new Planet", order = 51)]
public class PlanetSO : AbstractPlanetSO
{
    [SerializeField, Tooltip("Optional, if nothing will use standart Generator name")] private string _name;


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

    public string Name { get => _name; set => _name = value; }
    public PlanetSO[] Satellites { get => _satellites; set => _satellites = value; }
    public int OrbitDistance { get => _orbitDistance; set => _orbitDistance = value; }
    public int Gas { get => _gas; set => _gas = value; }
    public int Water { get => _water; set => _water = value; }
    public int Ground { get => _ground; set => _ground = value; }
    public int Metal { get => _metal; set => _metal = value; }
    public ColorSO[] GasColor { get => _gasColor; set => _gasColor = value; }
    public ColorSO[] WaterColor { get => _waterColor; set => _waterColor = value; }
    public ColorSO[] GroundColor { get => _groundColor; set => _groundColor = value; }
    public ColorSO[] MetalColor { get => _metalColor; set => _metalColor = value; }
}
