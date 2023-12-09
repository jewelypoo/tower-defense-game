using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles nodes throughout the game where player can build on]
 */
public class Node : MonoBehaviour
{
    public GameObject cannon;
    public Vector3 positionOffset;


    BuildManager buildManager;


    public void Start()
    {
        buildManager = BuildManager.instance;
    }

    /// <summary>
    /// when mouse is clicked on node then they can build
    /// </summary>
    public void OnMouseEnter()
    {
        if (buildManager.CanBuild)
            return;
    }

    /// <summary>
    /// build on the node
    /// </summary>
    /// <returns></returns>
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;

    }
    
    /// <summary>
    /// if mouse is clicked anyhwhere other than a node then they can not place a cannon
    /// </summary>
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
