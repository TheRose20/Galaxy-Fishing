using UnityEngine;
public class FactoryStarSystem : Singleton<FactoryStarSystem>
{
    [SerializeField] private FactoryStarSystemSO _factoryParam;

    [SerializeField, Tooltip("ReadOnly")] private uint _numStarSystems = 0;

    public StarSystem GetOnlyStarSystem(uint id)
    {
        Random.InitState((int)id);
        return CreateOnlyStarSystem(id);
    }

    private StarSystem CreateOnlyStarSystem(uint id)
    {
        StarSystem starSystem = new StarSystem();
        uint starSystemId = id;

        if (_factoryParam.StarsSystemParamUltra.Length >= _numStarSystems)
        {
            StarSO starParam = _factoryParam.StarsSystemParamUltra[_numStarSystems].StarSystemParam.Star;
            Star star = StarFactory.Instance.GetStar(id, starParam);



        }

        return null;
    }
}