using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBuilding : Building
{
    private string resourceType;
    private int maxResources;
    private int remResources;
    private int resourcePerTick;

    public string ResourceType // properties
    {
        get
        {
            return resourceType;
        }

        set
        {
            resourceType = value;
        }
    }

    public int MaxResources
    {
        get
        {
            return maxResources;
        }

        set
        {
            maxResources = value;
        }
    }

    public int RemResources
    {
        get
        {
            return remResources;
        }

        set
        {
            remResources = value;
        }
    }

    public int ResourcePerTick
    {
        get
        {
            return resourcePerTick;
        }

        set
        {
            resourcePerTick = value;
        }
    }
    public ResourceBuilding(int buildPosX, int buildPosY, int buildHp, char faction, char buildSym, string resourceType, int maxResources, int remResources, int resourcePerTick)
        : base(buildPosX, buildPosY, buildHp, faction, buildSym)                                                   //constructor
    {
        BuildPosX = buildPosX;
        BuildPosY = buildPosY;
        BuildHp = buildHp;
        Faction = faction;
        BuildSym = buildSym;
        ResourceType = resourceType;
        RemResources = remResources;
        MaxResources = maxResources; // actually represents current amount of resources
        ResourcePerTick = resourcePerTick;
    }

    public void generateResources()
    {
        maxResources = maxResources + resourcePerTick;
        remResources = remResources - resourcePerTick;
    }

    public override void buildSave()
    {
        
    }
    public override string ToString()
    {
        return ("Hello, This is a Resource tower for the " + Faction + " Faction. It has generated " + MaxResources + ResourceType + " .And can Generate " + RemResources + " more");
    }

}
