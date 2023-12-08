using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private GameObject cannon;

    BuildManager buildManager;


    public void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void OnMouseDown()
    {
        if (buildManager.GetCannonToBuild() == null)
        
            return;
        

        if (cannon != null)
        {
            return;
        }

        GameObject cannonToBuild = BuildManager.instance.GetCannonToBuild();
        cannon = (GameObject)Instantiate(cannonToBuild, transform.position, transform.rotation);

    }



}
