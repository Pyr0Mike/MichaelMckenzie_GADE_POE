using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryBuilding : Building
{
    private char unitType;
    private int spawnRate;
    private int spawnXpos;
    private int spawnYpos;

    public char UnitType     //properties
    {
        get
        {
            return unitType;
        }

        set
        {
            unitType = value;
        }
    }

    public int SpawnRate
    {
        get
        {
            return spawnRate;
        }

        set
        {
            spawnRate = value;
        }
    }

    public int SpawnXpos
    {
        get
        {
            return spawnXpos;
        }

        set
        {
            spawnXpos = value;
        }
    }

    public int SpawnYpos
    {
        get
        {
            return spawnYpos;
        }

        set
        {
            spawnYpos = value;
        }
    }

    public FactoryBuilding(int buildPosX, int buildPosY, int buildHp, char faction, char buildSym, char unitType, int spawnRate)
        : base(buildPosX, buildPosY, buildHp, faction, buildSym)                                                              //constructor
    {
        BuildPosX = buildPosX;
        BuildPosY = buildPosY;
        BuildHp = buildHp;
        Faction = faction;
        BuildSym = buildSym;
        UnitType = unitType;
        SpawnRate = spawnRate;
    }

    public Unit generateUnit()
    {

        Unit newUnit;

        if (BuildPosY >= 19)          // deciding where to spawn a new unit
        {
            SpawnYpos = BuildPosY - 1;
        }

        else
        {
            SpawnYpos = BuildPosY + 1;
        }

        SpawnXpos = BuildPosX;

        if (Faction == 'R' && UnitType == 'K')        // creating a new unit
        {
            newUnit = new MeleeUnit(SpawnXpos, SpawnYpos, 100, 100, 2, 20, 1, 'R', 'K', "KNIGHT");
            return newUnit;
        }

        else if (Faction == 'R' && UnitType == 'A')
        {
            newUnit = new RangedUnit(SpawnXpos, SpawnYpos, 100, 100, 1, 10, 3, 'R', 'A', "Archer");
            return newUnit;
        }

        else if (Faction == 'B' && UnitType == 'k')
        {
            newUnit = new MeleeUnit(SpawnXpos, SpawnYpos, 100, 100, 2, 20, 1, 'B', 'k', "KNIGHT");
            return newUnit;
        }

        else
        {
            newUnit = new RangedUnit(SpawnXpos, SpawnYpos, 100, 100, 1, 10, 3, 'B', 'a', "Archer");
            return newUnit;
        }





    }

    public override void buildSave()
    {
       
    }

    public override string ToString()
    {
        return ("Hi I'm a Factory Building for the " + Faction + " , and I produce " + UnitType + " units");
    }



}
