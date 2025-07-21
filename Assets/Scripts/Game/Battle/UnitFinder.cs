using System.Collections.Generic;
using System.Linq; 
using UnityEngine;
using HZI.Shared.Entities;

// this static class will help find the object type <Unit> in the battle scene. and it can be some filter added.
public static class UnitFinder
{
    // this method finds all units in the scene and returns them as a list.
    public static List<Unit> GetSceneUnits()
    {
        // Find all objects of type Unit in the scene
        List<Unit> units = Object.FindObjectsByType<Unit>(FindObjectsSortMode.None).ToList();
        
        return units;
    }
}