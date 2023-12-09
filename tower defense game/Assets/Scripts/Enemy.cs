using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


/*
 * Author: [Fain, Jewel / Gibson, Hannah]
 * Last Updated: [12/8/2023]
 * [determines health/speed/and value for enemies as well as if they can die and their movement]
 */


public class Enemy : MonoBehaviour
{
    public float speed = 7f;

    public int health = 3;

    public int moneyDropped = 50;

    private Transform target;
    //array for waypoints
    private int wayPointIndex = 0;

    void Start()
    {
        target = WayPoints.wayPoints[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            ReachNextWayPoint();
        }
    }

    /// <summary>
    /// allows enemy to take damage and die when health reaches 0
    /// </summary>
    /// <param name="amount"> the amount of damage taken</param>
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health<=0)
        {
            Die();
        }
    }
    /// <summary>
    /// when enemy reaches 0 they are destroyed and drop money to player
    /// </summary>
    public void Die()
    {
        PlayerStats.Money += moneyDropped;

        Destroy(gameObject);
    }

    //the enemy moves to each respective waypoint
    public void ReachNextWayPoint()
    {
        //when the enemy reaches the last point, it's destroyed
        if (wayPointIndex >= WayPoints.wayPoints.Length - 1)
        {
            EndPath();
            return;
        }
        wayPointIndex++;
        target = WayPoints.wayPoints[wayPointIndex];
    }

    /// <summary>
    /// if the enemy reaches the end takes one health from player lives and is destroyed
    /// </summary>
    public void EndPath()
    {
        PlayerStats.lives--;
        Destroy(gameObject);

    }



}
