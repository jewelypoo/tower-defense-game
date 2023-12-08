using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void purchaseBasicCannon()
    {
        buildManager.SetCannonToBuild(buildManager.standardCannonPrefab);
    }

    public void purchaseLongCannon()
    {
        buildManager.SetCannonToBuild(buildManager.longCannonPrefab);
    }






}
