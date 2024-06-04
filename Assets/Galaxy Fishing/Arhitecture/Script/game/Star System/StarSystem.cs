using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Star))]
public class StarSystem : AbstractObject
{
    [Header("Planets")]
    [SerializeField] private Star _star;
    [SerializeField] private AbstractPlanet[] _planets;

    [SerializeField] private string _tag = "None Tagget";
    public string Tag => _tag;
}

public enum HobitableZoneType
{
    DeafoudlHobitableZone,
    UseHobitableZoneOffset,
    HobitableZoneRandom
}
