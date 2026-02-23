using UnityEngine;


public class StarFactory : Singleton<StarFactory>
{

    public Star GetStar(uint id, StarRandomSO starParam)
    {
        Random.InitState((int)id);
        return CreateRandomStar(id, starParam);
    }

    public Star GetStar(uint id, StarSO starParam)
    {
        Random.InitState((int)id);
        return CreateStar(id, starParam);

    }

    private Star CreateStar(uint id, StarSO param)
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
    private Star CreateRandomStar(uint id, StarRandomSO param)
    {
        Star star = new Star();
        star.SetId(id);

        uint mass = (uint)Random.Range(param.MinMass, param.MaxMass);
        float radius = Random.Range(param.MinRadius, param.MaxRadius);
        float lightStrengh = Random.Range(param.MinLightStrenght, param.MaxLightStrenght);

        string name = $"GenaricStar  {Random.Range(10, 100)} - {Random.Range(200 , 300)}"; //refactor

        star.SetName(name);
        star.Init(mass, radius, lightStrengh);


        return star;
    }
}
