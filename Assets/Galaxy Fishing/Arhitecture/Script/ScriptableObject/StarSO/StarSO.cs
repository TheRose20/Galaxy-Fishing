using UnityEngine;

[CreateAssetMenu(fileName = "Star", menuName = "Planet/Star/Create new Star", order = 51)]

public class StarSO : AbstractPlanetSO
{
    [SerializeField, Tooltip("Optional, if nothing will use standart Generator name")] private string _name;

    [SerializeField] private float _lightStrenght;
    [SerializeField] private ColorSO[] _colors;

    public float LightStrenght { get => _lightStrenght; set => _lightStrenght = value; }
    public ColorSO[] Colors { get => _colors; set => _colors = value; }
    public string Name { get => _name; set => _name = value; }
}