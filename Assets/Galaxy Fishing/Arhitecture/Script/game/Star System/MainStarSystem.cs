using UnityEngine;

public class MainStarSystem : Singleton<MainStarSystem>
{
    #region IDNAME
    [SerializeField] private int _id;
    [SerializeField] private string _name;

    public void SetNameId(int id, string name)
    {
        _name = name;
        _id = id;
    } 
    #endregion

    [SerializeField] private float _minDistanceToMaintainOrbit;
    [SerializeField] private float _maxDistanceToMaintainOrbit;

    [Header("HobitableZone")]
    [SerializeField] private HobitableZoneType _hobitableZoneType = HobitableZoneType.DeafoudlHobitableZone;
    [SerializeField] private float _hobitableZoneStart = 60;
    [SerializeField] private float _hobitableZoneWidth = 30;


    //public
}