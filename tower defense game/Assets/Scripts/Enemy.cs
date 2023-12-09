using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

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


    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health<=0)
        {
            Die();
        }
    }
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

    public void EndPath()
    {
        PlayerStats.lives--;
        Destroy(gameObject);

    }



}
