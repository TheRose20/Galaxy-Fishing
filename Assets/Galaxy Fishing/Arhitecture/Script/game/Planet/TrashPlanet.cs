using UnityEngine;

public class TrashPlanet : AbstractPlanet
{
    [SerializeField] private int _trashMass;
    [SerializeField] private int _metalMass;

    public int TrashMass => _trashMass;
    public int MetalMass => _metalMass;
}