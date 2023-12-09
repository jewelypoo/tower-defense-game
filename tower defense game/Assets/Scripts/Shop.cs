using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardCannon;
    public TurretBlueprint longCannon;
    
    BuildManager buildManager;

    public void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void selectBasicCannon()
    {
        buildManager.SelectCannonToBuild(standardCannon);
    }

    public void selectLongCannon()
    {
        buildManager.SelectCannonToBuild(longCannon);
    }






}
