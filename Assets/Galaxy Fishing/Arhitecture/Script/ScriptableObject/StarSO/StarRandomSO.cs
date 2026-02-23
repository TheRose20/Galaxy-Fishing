using UnityEngine;

[CreateAssetMenu(fileName = "StarRandom", menuName = "Planet/Star/Create new StarRandom", order = 51)]

public class StarRandomSO : AbstractPlanetRandomSO
{
    [SerializeField] private float _minLightStrenght = 20;
    [SerializeField] private float _maxLightStrenght = 200;

    [SerializeField] private ColorSO[] _colors;

    public float MinLightStrenght { get => _minLightStrenght; set => _minLightStrenght = value; }
    public float MaxLightStrenght { get => _maxLightStrenght; set => _maxLightStrenght = value; }
    public ColorSO[] Colors { get => _colors; set => _colors = value; }
}