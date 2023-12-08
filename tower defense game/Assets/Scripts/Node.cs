using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private GameObject cannon;


    public void OnMouseDown()
    {
        if (cannon != null)
        { 
            return;
        }

        GameObject cannonToBuild = BuildManager.instance.GetCannonToBuild();
        cannon = Instantiate(cannonToBuild, transform.position, transform.rotation);

    }



}
