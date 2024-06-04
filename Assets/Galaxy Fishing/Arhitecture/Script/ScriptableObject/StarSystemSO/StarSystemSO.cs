using UnityEngine;

public class StarSystemSO : ScriptableObject
{
    [SerializeField] private StarSO _star;

    [SerializeField] private PlanetSO[] _planets;

}