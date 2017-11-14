using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{

    Random rando = new Random();
    Unit[] unitArray = new Unit[10];           // arrays
    Building[] buildArray = new Building[6];
    char[,] mapArray = new char[20, 20];

    public Unit[] UnitArray          // properties
    {
        get
        {
            return unitArray;
        }

        set
        {
            unitArray = value;
        }
    }

    public Building[] BuildArray
    {
        get
        {
            return buildArray;
        }

        set
        {
            buildArray = value;
        }
    }

    public char[,] MapArray
    {
        get
        {
            return mapArray;
        }

        set
        {
            mapArray = value;
        }
    }

    public Map(int unitNumber, int buildNumber) // constructor
    {

        // populateMap();
        createMap();
        populateMap();




    }

    public string createMap()
    {
        // filling the map array with blank . characters 
        string mapLabel = "";
        for (int k = 0; k < 20; k++)
        {


            for (int i = 0; i < 20; i++)
            {
                MapArray[k, i] = '.';
                mapLabel += MapArray[k, i];

            }
            mapLabel += "\n";
        }

        return mapLabel;



    }

    public void populateMap()
    {

        createUnit();
        createBuilding();
        fillMap();




    }

    public void createUnit()
    {
        for (int i = 0; i < unitArray.Length; i++)
        {
            int newUnitXpos = rando.Next(0, 20);      //creates units
            int newUnitYpos = rando.Next(0, 20);
            int type = rando.Next(0, 4);

            if (type == 0)
            {
                unitArray[i] = new MeleeUnit(newUnitXpos, newUnitYpos, 100, 100, 2, 20, 1, 'R', 'K', "KNIGHT");

            }
            if (type == 1)
            {
                unitArray[i] = new MeleeUnit(newUnitXpos, newUnitYpos, 100, 100, 2, 20, 1, 'B', 'k', "KNIGHT");
            }
            if (type == 2)
            {
                unitArray[i] = new RangedUnit(newUnitXpos, newUnitYpos, 100, 100, 1, 10, 3, 'R', 'A', "Archer");
            }
            if (type == 3)
            {
                unitArray[i] = new RangedUnit(newUnitXpos, newUnitYpos, 100, 100, 1, 10, 3, 'B', 'a', "Archer");
            }


        }
    }

    public void createBuilding()
    {

        for (int b = 0; b < buildArray.Length; b++)     //creates buildings
        {
            int newBuildXpos = rando.Next(0, 20);
            int newBuildYpos = rando.Next(0, 20);
            int buildType = rando.Next(0, 6);
            if (buildType == 0)
            {
                buildArray[b] = new FactoryBuilding(newBuildXpos, newBuildYpos, 200, 'R', 'T', 'K', 2);
            }
            if (buildType == 1)
            {
                buildArray[b] = new FactoryBuilding(newBuildXpos, newBuildYpos, 200, 'R', 'X', 'A', 1);
            }
            if (buildType == 2)
            {
                buildArray[b] = new FactoryBuilding(newBuildXpos, newBuildYpos, 200, 'B', 't', 'k', 2);
            }
            if (buildType == 3)
            {
                buildArray[b] = new FactoryBuilding(newBuildXpos, newBuildYpos, 200, 'B', 'x', 'a', 1);
            }
            if (buildType == 4)
            {
                buildArray[b] = new ResourceBuilding(newBuildXpos, newBuildYpos, 200, 'R', 'S', "IRON", 50, 10, 2);
            }
            if (buildType == 5)
            {
                buildArray[b] = new ResourceBuilding(newBuildXpos, newBuildYpos, 200, 'B', 's', "IRON", 50, 10, 2);
            }
        }
    }

    public void fillMap()
    {




        /*  for (int v = 0; v < unitArray.Length; v++) // puts units into Map Array
          {
              mapArray[unitArray[v].XPos, unitArray[v].YPos] = unitArray[v].Symbol;
          }
          for (int b = 0; b < buildArray.Length; b++) // puts buildings into Map Array
          {
              mapArray[buildArray[b].BuildPosX, buildArray[b].BuildPosY] = buildArray[b].BuildSym;
          }*/

        foreach (Unit merc in unitArray)
        {
            MapArray[merc.XPos, merc.YPos] = merc.Symbol;
        }

        foreach (Building tower in buildArray)
        {
            MapArray[tower.BuildPosX, tower.BuildPosY] = tower.BuildSym;
        }





    }
    public void moveUnit()
    {

    }

    public void updateUnit()
    {

    }

    public void updateMap()
    {

    }

    public void loadFromFile()
    {

    }
    public override string ToString()

    {
        // filling the map array with blank . characters 
        string mapLabel = "";
        for (int k = 0; k < 20; k++)
        {


            for (int i = 0; i < 20; i++)
            {
                mapLabel += MapArray[k, i];

            }
            mapLabel += "\n";
        }

        return mapLabel;
    }



}
