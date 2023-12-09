using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

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

    public void SelectCannonToBuild(TurretBlueprint cannon)
    {
        cannonToBuild = cannon;
    }

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
