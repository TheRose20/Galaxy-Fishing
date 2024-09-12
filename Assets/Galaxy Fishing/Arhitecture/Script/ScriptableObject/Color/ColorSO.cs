using UnityEngine;

[CreateAssetMenu(fileName = "newColors", menuName = "Colors/Create Colors", order = 51)]
public class ColorSO : ScriptableObject
{
    [SerializeField] private Color _color1 = Color.white;
    [SerializeField] private Color _color2 = Color.black;

    public Color Color1 { get => _color1; set => _color1 = value; }
    public Color Color2 { get => _color2; set => _color2 = value; }
}