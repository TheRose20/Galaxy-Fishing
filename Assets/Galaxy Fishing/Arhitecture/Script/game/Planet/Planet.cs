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

    public Transform OrbitCenter { get => _orbitCenter; set => _orbitCenter = value; }
    public float OrbitDistance { get => _orbitDistance; set => _orbitDistance = value; }
    public PlanetZones PlanetZones { get => _planetZones; set => _planetZones = value; }
    public List<Planet> Satellites { get => _satellites; set => _satellites = value; }
    public int Gas { get => _gas; set => _gas = value; }
    public int Water { get => _water; set => _water = value; }
    public int Ground { get => _ground; set => _ground = value; }
    public int Metal { get => _metal; set => _metal = value; }

    public void Init(Planet planet)
    {
        _orbitCenter = planet.OrbitCenter;
        _orbitDistance = planet.OrbitDistance;

        _water = planet.Water;
        _ground = planet.Ground;
        _metal = planet.Metal;
        _gas = planet.Gas;


    }

    public void InitZoneInStarSystem()
    {

    }
}