using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject cannon;
    public Vector3 positionOffset;


    BuildManager buildManager;


    public void Start()
    {
        buildManager = BuildManager.instance;
    }


    public void OnMouseEnter()
    {
        if (buildManager.CanBuild)
            return;
    }


    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;

    }
    

    public void OnMouseDown()
    {
        if (!buildManager.CanBuild)
        
            return;
        

        if (cannon != null)
        {
            return;
        }

        buildManager.BuildCannonOn(this);
        

    }



}
