using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles waypoints for the enemies to travel to ]
 */
public class WayPoints : MonoBehaviour
{
    public static Transform[] wayPoints;

    public void Awake()
    {
        wayPoints = new Transform[transform.childCount];
        for (int i = 0; i < wayPoints.Length; i++)
        {
            wayPoints[i] = transform.GetChild(i);
        }
    }
}
