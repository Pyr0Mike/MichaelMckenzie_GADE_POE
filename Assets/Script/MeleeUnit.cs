using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Unit
{

    public MeleeUnit(int unitXPos, int unitYPos, int unitMaxHp, int unitCurHp, int unitSpeed,      //constructor
        int unitAttack, int unitRange, char unitFaction, char unitSymbol, string unitName) : base(unitXPos, unitYPos, unitMaxHp, unitCurHp, unitSpeed,
        unitAttack, unitRange, unitFaction, unitSymbol, unitName)
    {

    }

    //overriden methods

    public override void move()
    {
        
    }
    public override void combat(Unit enemy)
    {
        enemy.CurHp = enemy.CurHp - Attack;
    }
    public override void runAway()
    {
        
    }
    public override bool amDead()
    {
        bool dead = false;

        if (CurHp <= 0)
        {
            dead = true;
        }

        return dead;
    }
    public override Unit closestUnit(Unit[] targetArray)
    {
        Unit enemyTarget;
        int tempXdistance = 50;
        int tempYdistance = 50;

        foreach (Unit target in targetArray)// finding closest enemy unit
        {
            if (target.Faction != Faction)
            {
                if (XPos - target.XPos < tempXdistance && YPos - target.YPos < tempYdistance)     //figuring out which unit is closest          
                {
                    tempXdistance = XPos - target.XPos;
                    tempYdistance = YPos - target.YPos;
                    enemyTarget = target;

                }
            }
        }

        return enemyTarget;
    }
    public override bool rangeCheck()
    {
        
    }
    public override void save()
    {
        
    }
    public override void ToString()
    {
        Debug.Log("Hi, I am a" + Name + " I am with the " + Faction + " faction. I have " + MaxHp + " Health, and do " + Attack + " Damage.");
    }





}
