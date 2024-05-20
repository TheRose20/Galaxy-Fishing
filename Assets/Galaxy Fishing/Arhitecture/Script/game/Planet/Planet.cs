using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(SphereCollider), typeof(Orbit))]
public class Planet : AbstractPlanet
{
    [SerializeField] private Transform _orbitCenter;
    [SerializeField] private float _orbitDistance;

    [SerializeField] private PlanetZones _planetZones;
    [SerializeField] private List<Planet> _satellites;

    [SerializeField] private int _gas;
    [SerializeField] private int _water;
    [SerializeField] private int _ground;
    [SerializeField] private int _metal;


}