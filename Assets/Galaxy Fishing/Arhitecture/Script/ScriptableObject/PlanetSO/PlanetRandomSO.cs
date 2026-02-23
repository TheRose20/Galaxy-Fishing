using UnityEngine;

[CreateAssetMenu(fileName = "PlanetRandom", menuName = "Planet/Planets/Create new PlanetRandom", order = 51)]
public class PlanetRandomSO : AbstractPlanetRandomSO
{
    [Header("Satellites")]
    [SerializeField, Range(0f, 1f)] private float _chanceOfCreationAsSetellite = 0f;
    [SerializeField] private PlanetRandomSO _satellites;
    [Space]
    [SerializeField] private int _minOrbitDistance = 66;
    [SerializeField] private int _maxOrbitDistance = 66;

    [Header("Param")]
    [SerializeField] private int _minGas = 20;
    [SerializeField] private int _maxGas = 50;

    [SerializeField] private int _minWater = 200;
    [SerializeField] private int _maxWater = 250;

    [SerializeField] private int _minGround = 500;
    [SerializeField] private int _maxGround = 550;

    [SerializeField] private int _minMetal = 150;
    [SerializeField] private int _maxMetal = 300;

    [Header("Colors")]
    [SerializeField] private ColorSO[] _gasColor;
    [SerializeField] private ColorSO[] _waterColor;
    [SerializeField] private ColorSO[] _groundColor;
    [SerializeField] private ColorSO[] _metalColor;

    public float ChanceOfCreationAsSetellite { get => _chanceOfCreationAsSetellite; set => _chanceOfCreationAsSetellite = value; }
    public PlanetRandomSO Satellites { get => _satellites; set => _satellites = value; }
    public int MinOrbitDistance { get => _minOrbitDistance; set => _minOrbitDistance = value; }
    public int MaxOrbitDistance { get => _maxOrbitDistance; set => _maxOrbitDistance = value; }
    public int MinGas { get => _minGas; set => _minGas = value; }
    public int MaxGas { get => _maxGas; set => _maxGas = value; }
    public int MinWater { get => _minWater; set => _minWater = value; }
    public int MaxWater { get => _maxWater; set => _maxWater = value; }
    public int MinGround { get => _minGround; set => _minGround = value; }
    public int MaxGround { get => _maxGround; set => _maxGround = value; }
    public int MinMetal { get => _minMetal; set => _minMetal = value; }
    public int MaxMetal { get => _maxMetal; set => _maxMetal = value; }
    public ColorSO[] GasColor { get => _gasColor; set => _gasColor = value; }
    public ColorSO[] WaterColor { get => _waterColor; set => _waterColor = value; }
    public ColorSO[] GroundColor { get => _groundColor; set => _groundColor = value; }
    public ColorSO[] MetalColor { get => _metalColor; set => _metalColor = value; }
}