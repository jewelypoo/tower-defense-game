using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles the shop.
 * Allows players to be able to to select a cannon and for the scne to build it and place it down]
 */
public class Shop : MonoBehaviour
{
    public TurretBlueprint standardCannon;
    public TurretBlueprint longCannon;
    
    BuildManager buildManager;

    public void Start()
    {
        buildManager = BuildManager.instance;
    }
    /// <summary>
    /// allows player to select a cannon - faster cannon
    /// </summary>
    public void selectBasicCannon()
    {
        buildManager.SelectCannonToBuild(standardCannon);
    }
    /// <summary>
    /// allows player to select and load a long distance cannon
    /// </summary>
    public void selectLongCannon()
    {
        buildManager.SelectCannonToBuild(longCannon);
    }






}
