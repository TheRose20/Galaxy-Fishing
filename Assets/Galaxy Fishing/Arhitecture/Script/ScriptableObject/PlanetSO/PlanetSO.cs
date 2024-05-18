using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSO : AbstractPlanetSO
{
    [SerializeField] private Transform _orbitCenter;
    [SerializeField] private int _orbitDistance;
    [SerializeField] private float _orbitSpeed;

    [SerializeField] private PlanetZones _planetZones;
    [SerializeField] private List<Planet> _satellites;

    [SerializeField] private int _gas;
    [SerializeField] private int _water;
    [SerializeField] private int _ground;
    [SerializeField] private int _metal;

    public void SetOrbit(Transform orbitCenter, int orbitDistance, float orbitSpeed)
    {
        _orbitCenter = orbitCenter;
        _orbitDistance = orbitDistance;
        _orbitSpeed = orbitSpeed;
    }

    //public bool
}
//
