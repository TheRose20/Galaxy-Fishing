using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;


public class StarFactory : Singleton<StarFactory>
{

    public Star GetStar(int id, StarRandomSO starParam)
    {
        Random.InitState(id);
        return CreateRandomStar(id, starParam);
    }

    public Star GetStar(int id, StarSO starParam)
    {
        Random.InitState(id);
        return CreateStar(id, starParam);

    }

    private Star CreateStar(int id, StarSO param)
    {
        Star star = new Star();
        star.SetId((uint)id);

        if (param.Name == "")
        {
            //Generate Name
            star.SetName(Random.Range(0, 150) + " Random Name (Create Name generator)");
        }
        else star.SetName(param.Name);

        star.Init(param.Mass, param.Radius, param.LightStrenght);

        return star;
    }
    private Star CreateRandomStar(int id, StarRandomSO param)
    {
        Star star = new Star();
        star.SetId((uint)id);

        uint mass = (uint)Random.Range(param.MinMass, param.MaxMass);
        uint radius = (uint)Random.Range(param.MinRadius, param.MaxRadius);
        float lightStrengh = Random.Range(param.MinLightStrenght, param.MaxLightStrenght);

        string name = $"GenaricStar  {Random.Range(10, 100)} - {Random.Range(200 , 300)}"; //refactor

        star.SetName(name);
        star.Init(mass, radius, lightStrengh);

        return star;
    }
}
