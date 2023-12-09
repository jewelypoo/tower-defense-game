using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*
 * Author: [Fain, Jewel / Gibson, Hannah]
 * Last Updated: [12/8/2023]
 * [checks if the player can build and which cannon/checks if player has enough money for cannon]
 */
public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;
    /// <summary>
    /// to allow the scene to have the game objects availabel to the plaeyr if they are playing
    /// </summary>
    public void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }
    public GameObject standardCannonPrefab;
    public GameObject longCannonPrefab;


    private TurretBlueprint cannonToBuild;


    //public bool (property) that checks if nodes are able to be built on
    public bool CanBuild { get { return cannonToBuild != null; } }
    //checks if player has enough money
    //public bool HasMoney { get { return PlayerStats.Money >= cannonToBuild.cost; } }
    /// <summary>
    /// when you select a cannon you can place it in the scene 
    /// </summary>
    /// <param name="cannon"> refers to cannon in that script</param>
    public void SelectCannonToBuild(TurretBlueprint cannon)
    {
        cannonToBuild = cannon;
    }
    /// <summary>
    /// checks to see if the player has enough money to purchase a cannon 
    /// if they do not they are met with a message saying they do not have enough money
    /// </summary>
    /// <param name="node"> refers to the node you can place on the map</param>
    public void BuildCannonOn(Node node)
    {
        //checks if player has enough money for the cannon
        if (PlayerStats.Money < cannonToBuild.cost)
        {
            Debug.Log("Not enough money!");
            return;

        }
        //subtracts players money from how much it cost to build turret
        PlayerStats.Money -= cannonToBuild.cost;

        GameObject cannon = (GameObject)Instantiate(cannonToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.cannon = cannon;

        //displays new currency in log
        Debug.Log("Cannon Built. Money Left: " + PlayerStats.Money);

    }


}
