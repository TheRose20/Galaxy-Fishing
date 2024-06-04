using UnityEngine;

[CreateAssetMenu(fileName = "PlanetRandom", menuName = "Planet/Planets/Create new PlanetRandom", order = 51)]
public class PlanetRandomSO : AbstractPlanetRandomSO
{
    [Header("Satellites")]
    [SerializeField] private PlanetSO[] _satellites;
    [Space]
    [SerializeField] private int _minOrbitDistance = 66;
    [SerializeField] private int _maxOrbitDistance = 66;

    [Header("Param")]
    [SerializeField] private int _minGas = 20;
    [SerializeField] private int _maxGas = 50;

    [SerializeField] private int _minWater = 200;
    [SerializeField] private int _maxWater = 250;

    [SerializeField] private int _miGround = 500;
    [SerializeField] private int _maxGround = 550;

    [SerializeField] private int _minMetal = 150;
    [SerializeField] private int _maxMetal = 300;

    [Header("Colors")]
    [SerializeField] private ColorSO[] _gasColor;
    [SerializeField] private ColorSO[] _waterColor;
    [SerializeField] private ColorSO[] _groundColor;
    [SerializeField] private ColorSO[] _metalColor;
}