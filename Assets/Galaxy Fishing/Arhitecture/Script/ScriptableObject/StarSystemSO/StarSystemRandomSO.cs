using UnityEngine;

public class StarSystemRandomSO : ScriptableObject
{
    [SerializeField] private StarRandomSO _starParam;
    [SerializeField] private PlanetRandomSO _planetParam;
}