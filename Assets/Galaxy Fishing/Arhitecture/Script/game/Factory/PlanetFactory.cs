using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Galaxy_Fishing.Arhitecture.Script.game.Factory
{
    public class PlanetFactory : MonoBehaviour
    {
        public Planet GetPlanet(uint id, PlanetSO param)
        {
            Planet planet = new Planet();

            planet.SetId(id);

            if (param.Name == "")
            {
                //Generate Name
                planet.SetName(Random.Range(0, 150) + " Random Name (Create Name generator)");
            }
            else planet.SetName(param.Name);

            planet.Init(param.Mass, param.Radius);
            return planet;

        }

        public Planet GetPlanet(uint id, PlanetRandomSO param)
        {
            Planet planet = new Planet();

            int gas = RandomInt(param.MinGas, param.MaxGas);
            int water = RandomInt(param.MinWater, param.MaxWater);
            int ground = RandomInt(param.MinGround, param.MaxGround);
            int metal = RandomInt(param.MinMetal, param.MaxMetal);

            int mass = gas + water + ground + metal;


            while (mass > param.MaxMass)
            {
                gas = gas - 10;
                water = water - 10;
                ground = ground - 10;
                metal = metal - 10;

                mass = gas + water + ground + metal;
            }
            while (mass < param.MinMass)
            {
                gas = gas + 10;
                water = water + 10;
                ground = ground + 10;
                metal = metal + 10;

                mass = gas + water + ground + metal;
            }

            float radius = (uint)Random.Range(param.MinRadius, param.MaxRadius);
            planet.Init((uint)mass, radius, planet);

            return planet;
        }

        //private Planet CreatePlanet()

        private int RandomInt(int min, int max)
        {
            return Random.Range(min, max);
        }
    }
}