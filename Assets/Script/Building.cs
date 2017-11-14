using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building
{
    public int buildPosX;
    public int buildPosY;
    public int buildHp;
    public char faction;
    public char buildSym;




    public int BuildPosX
    {
        get
        {
            return buildPosX;
        }

        set
        {
            buildPosX = value;
        }
    }

    public int BuildPosY
    {
        get
        {
            return buildPosY;
        }

        set
        {
            buildPosY = value;
        }
    }

    public int BuildHp
    {
        get
        {
            return buildHp;
        }

        set
        {
            buildHp = value;
        }
    }

    public char Faction
    {
        get
        {
            return faction;
        }

        set
        {
            faction = value;
        }
    }

    public char BuildSym
    {
        get
        {
            return buildSym;
        }

        set
        {
            buildSym = value;
        }
    }

    public Building(int buildPosX, int buildPosY, int buildHp, char faction, char buildSym) // constructor
    {


    }

    ~Building()
    {

    }

    public abstract string ToString();
    public abstract void buildSave();


}
