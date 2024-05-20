using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSO 
{
    [SerializeField] private Transform OrbitCenter;
    [SerializeField] private int OrbitDistance;

    [SerializeField] private PlanetZones PlanetZones;
    [SerializeField] private List<Planet> Satellites;

    [SerializeField] private int Gas;
    [SerializeField] private int Water;
    [SerializeField] private int Ground;
    [SerializeField] private int Metal;
}
