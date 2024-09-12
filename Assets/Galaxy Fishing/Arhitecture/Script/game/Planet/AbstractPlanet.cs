using UnityEngine;


public class AbstractPlanet : AbstractObject
{
    [Header("Second")]
    [SerializeField] protected uint Mass;
    [SerializeField] protected float Radius;

    public virtual void Init(uint mass, float radius)
    {
        Mass = mass;
        Radius = radius;
    }
}
