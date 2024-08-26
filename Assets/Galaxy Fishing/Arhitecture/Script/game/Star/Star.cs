using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : AbstractPlanet
{
    [SerializeField] private float _lightStrenght;
    public float LightStrenght => _lightStrenght;

    public void Init(uint mass, uint radius, float lightStrenght)
    {
        base.Init(mass, radius);

        _lightStrenght = lightStrenght;
    }
    
    public void Init(Star star)
    {
        base.Init(star.Mass, star.Radius);

        _lightStrenght = star.LightStrenght;
    }
}
