using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    private int xPos;
    private int yPos;
    private int maxHp;
    private int curHp;
    private int speed;
    private int attack;
    private int range;
    private char faction;
    private char symbol;
    private string name;



    public Unit(int unitXPos, int unitYPos, int unitMaxHp, int unitCurHp, int unitSpeed,
        int unitAttack, int unitRange, char unitFaction, char unitSymbol, string unitName) //constructor
    {
        xPos = unitXPos;
        yPos = unitYPos;
        maxHp = unitMaxHp;
        curHp = unitCurHp;
        speed = unitSpeed;
        attack = unitAttack;
        range = unitRange;
        faction = unitFaction;
        symbol = unitSymbol;
        name = unitName;
        /* unitXPos = xPos;
         unitYPos = yPos;
         unitMaxHp = maxHp;
         unitCurHp = curHp;
         unitSpeed = speed;
         unitAttack = attack;
         unitRange = range;
         unitFaction = faction;
         unitSymbol = symbol;
         unitName = name;*/



    }
    public int XPos
    {
        get
        {
            return xPos;
        }
        set
        {
            xPos = value;
        }
    }

    public int YPos
    {
        get
        {
            return yPos;
        }

        set
        {
            yPos = value;
        }
    }

    public int MaxHp
    {
        get
        {
            return maxHp;
        }

        set
        {
            maxHp = value;
        }
    }

    public int CurHp
    {
        get
        {
            return curHp;
        }

        set
        {
            curHp = value;
        }
    }

    public int Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public int Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }

    public int Range
    {
        get
        {
            return range;
        }

        set
        {
            range = value;
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

    public char Symbol
    {
        get
        {
            return symbol;
        }

        set
        {
            symbol = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    ~Unit() // deconstructor
    {

    }
    // abstract methods

    public abstract void move();

    public abstract void combat(Unit enemy);

    public abstract bool rangeCheck();

    public abstract Unit closestUnit(Unit[] targetArray);

    public abstract void runAway();

    public abstract bool amDead();

    public abstract void ToString();

    public abstract void save();






}
