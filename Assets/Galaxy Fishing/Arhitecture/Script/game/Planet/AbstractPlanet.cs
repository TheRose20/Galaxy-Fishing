using UnityEngine;


public class AbstractPlanet : AbstractObject
{
    [Header("Second")]
    [SerializeField] protected uint Mass;
    [SerializeField] protected uint Radius;

    public virtual void Init(uint mass, uint radius)
    {
        Mass = mass;
        Radius = radius;
    }
}
