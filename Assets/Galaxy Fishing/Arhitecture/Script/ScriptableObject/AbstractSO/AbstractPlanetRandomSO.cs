using UnityEngine;

public abstract class AbstractPlanetRandomSO : ScriptableObject
{
    [Header("Main")]
    [SerializeField] private uint minMass = 20;
    [SerializeField] private uint maxMass = 200;

    [Space]
    [SerializeField] private uint minRadius = 20;
    [SerializeField] private uint maxRadius = 200;

    public uint MinMass { get => minMass; set => minMass = value; }
    public uint MaxMass { get => maxMass; set => maxMass = value; }
    public uint MinRadius { get => minRadius; set => minRadius = value; }
    public uint MaxRadius { get => maxRadius; set => maxRadius = value; }
}