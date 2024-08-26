using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FactoryStarSystemParametrs", menuName = "Pararameters/Star System Factory", order = 51)]
public class FactoryStarSystemSO : ScriptableObject
{
    

    [SerializeField] private StarSystemParamUltra[] _starsSystemParam;
    [SerializeField] private StarSystemRandomSO[] _starsSystemRandomParam;

    public StarSystemParamUltra[] StarsSystemParam { get => _starsSystemParam; set => _starsSystemParam = value; }
    public StarSystemRandomSO[] StarsSystemRandomParam { get => _starsSystemRandomParam; set => _starsSystemRandomParam = value; }
}

[Serializable]
public class StarSystemParamUltra
{

    public StarSystemSO StarSystemParam;
    public uint CountInGalaxy = 1;
}