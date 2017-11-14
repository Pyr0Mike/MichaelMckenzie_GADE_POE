using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedUnit : Unit
{
    public RangedUnit(int unitXPos, int unitYPos, int unitMaxHp, int unitCurHp, int unitSpeed,      //constructor
        int unitAttack, int unitRange, char unitFaction, char unitSymbol, string unitName) : base(unitXPos, unitYPos, unitMaxHp, unitCurHp, unitSpeed,
        unitAttack, unitRange, unitFaction, unitSymbol, unitName)
    {
    }

    // overriden methods
    public override void combat(Unit enemy)
    {
        
    }
    public override Unit closestUnit(Unit[] targetArray)
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
    public override void move()
    {
        
    }
    public override bool rangeCheck()
    {
        bool inRange = false;

        return inRange;
    }
    public override void runAway()
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
