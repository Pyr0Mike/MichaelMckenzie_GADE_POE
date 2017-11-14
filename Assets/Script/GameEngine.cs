using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {



    private int tick = 0;
    private const int refresh = 60;

    // Use this for initialization
    public void Start () {

        Instantiate(Resources.Load("Grass"), new Vector3(0, 0, 0), Quaternion.identity);


        play();



    }

    public void play(){

         Map gameMap = new Map(10, 6);


    
      
     }

    public void playGame()
    {
        
        foreach (Building tower in gameMap.BuildArray)
        {
            string buildingType = tower.GetType().ToString();
            if (buildingType == "GADE_Project.ResourceBuilding.cs") //checking if a building is a resource building
            {
                if ((tower as ResourceBuilding).RemResources > 0)
                {
                    (tower as ResourceBuilding).generateResources();
                    (tower as ResourceBuilding).ToString();
                }

            }

            else //can only be a factory building if it isnt a resource building
            {
                if (tick % (tower as FactoryBuilding).SpawnRate == 0)
                {
                    Unit[] tempArray = new Unit[GameMap.UnitArray.Length + 1];
                    for (int i = 0; i < GameMap.UnitArray.Length; i++)
                    {
                        tempArray[i] = GameMap.UnitArray[i];
                    }

                    tempArray[GameMap.UnitArray.Length + 1] = (tower as FactoryBuilding).generateUnit();
                    GameMap.UnitArray = tempArray;
                }
            }


        }


    }
	
	// Update is called once per frame
	void Update () {
		




	}
}
