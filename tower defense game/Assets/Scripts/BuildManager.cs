using System.Collections;
using System.Collections.Generic;
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
    public GameObject betterCannonPrefab;


    private GameObject cannonToBuild;

    public GameObject GetCannonToBuild()
    {
        return cannonToBuild;
    }

    public void SetCannonToBuild(GameObject cannon)
    {
        cannonToBuild = cannon;
    }

}
