using UnityEngine;

public abstract class AbstractPlanetSO : ScriptableObject
{
    [Header("Main")]
    [SerializeField] private uint mass = 200;

    [Space]

    [SerializeField] private uint radius = 20;

    public uint Mass { get => mass; set => mass = value; }
    public uint Radius { get => radius; set => radius = value; }
}