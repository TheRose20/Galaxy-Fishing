using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newGenerateGalaxyParam", menuName = "Generate/new Galaxy Parameters", order = 51)]
public class GenerateGalaxySO : ScriptableObject
{
    [Header("Star Count")]
    [SerializeField] private uint _minStarsCount = 4000;
    [SerializeField] private uint _maxStarsCount = 5000;

    [Header("Distance")]
    [SerializeField] private uint _minDistanceBetweenStars = 40;
    [SerializeField] private uint _maxDistanceBetweenStars = 80;

    [Header("GalaxyDiameter")]
    [SerializeField] private uint _minDiameterGalaxy = 1500;
    [SerializeField] private uint _maxDiameterGalaxy = 2000;


    public uint MinStarsCount => _minStarsCount;
    public uint MaxStarsCount => _maxStarsCount;
    public uint MinDistanceBetweenStars => _minDistanceBetweenStars;
    public uint MaxDistanceBetweenStars => _maxDistanceBetweenStars;
    public uint MinDiameterGalaxy => _minDiameterGalaxy;
    public uint MaxDiameterGalaxy => _maxDiameterGalaxy;



#if UNITY_EDITOR
    //private void OnValidate()
    //{
    //    if (_maxStarsCount <= _minStarsCount)
    //    {
    //        _minStarsCount -= 5;
    //    }
    //    if (_maxDistanceBetweenStars <= _minDistanceBetweenStars)
    //    {
    //        _maxDistanceBetweenStars -= 5;
    //    }
    //    if (_maxDiameterGalaxy <= _minDiameterGalaxy)
    //    {
    //        _maxDiameterGalaxy -= 5;
    //    }
    //} 
#endif
}