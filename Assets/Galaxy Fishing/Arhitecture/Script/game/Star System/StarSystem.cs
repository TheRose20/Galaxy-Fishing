using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Star))]
public class StarSystem : AbstractObject
{
    [Header("Planets")]
    [SerializeField] private Star _star;
    [SerializeField] private AbstractPlanet[] _planets;

    [SerializeField] private string[] _tag;
    public string[] Tag => _tag;

    public void FastInit(uint id, StarSystemSO param)
    {

        _tag = new string[1];
        _tag[0] = param.Tag;

        _star.Init(param.Star.Mass, param.Star.Radius, param.Star.LightStrenght);

        _planets = param.Planets;
    }

    public void FastInit(uint id, StarSystemRandomSO param)
    {
        _tag = new string[1];
        _tag[0] = "Random " + param.Tag;

        uint mass = (uint)Random.Range(param.StarParam.MinMass, param.StarParam.MaxMass);
        uint radius = (uint)Random.Range(param.StarParam.MinRadius, param.StarParam.MaxRadius);
        float lightStrenght = Random.Range(param.StarParam.MinLightStrenght, param.StarParam.MaxLightStrenght);
        _star.Init(mass, radius, lightStrenght);


    }

    public void FullInit()
    {
        //Создание ЗС с созданием мешей\обьектов в новой сцене
    }
}

public enum HobitableZoneType
{
    DeafoudlHobitableZone,
    UseHobitableZoneOffset,
    HobitableZoneRandom
}