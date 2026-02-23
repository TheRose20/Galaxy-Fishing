using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewOrbitParameters", menuName = "Orbit/Create new orbit Parameters", order = 51)]
public class OrbitSO : ScriptableObject
{
    [SerializeField, Min(1)] private float _minSpeedToMaintainOrbit = 5f;
    [SerializeField, Min (2)] private float _maxSpeedToMaintainOrbit = 10f;

    public float MinSpeedToMaintainOrbit => _minSpeedToMaintainOrbit;
    public float MaxSpeedToMaintainOrbit => _maxSpeedToMaintainOrbit;

    private void OnValidate()
    {
        if (_minSpeedToMaintainOrbit >= _maxSpeedToMaintainOrbit)
        {
            Debug.LogWarning("Be careful, its dangerose!", this);
            _maxSpeedToMaintainOrbit = _minSpeedToMaintainOrbit + 1;
        }
    }
}
