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

    public void Start()
    {
        cannonToBuild = standardCannonPrefab;
    }

    private GameObject cannonToBuild;

    public GameObject GetTurretToBuild()
    {
        return cannonToBuild;
    }


}
