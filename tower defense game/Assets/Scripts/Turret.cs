using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles cannons]
 */
public class Turret : MonoBehaviour
{

    public Transform target;

    public float range = 8f;


    public string enemyTag = "Enemy";

    public Transform partToRotate;

    public float turnSpeed = 10f;

    public float fireRate = 1f;
    private float fireCountdown = 0.5f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    /// <summary>
    /// handles target update to track enemies
    /// </summary>
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance) 
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);

        if ( fireCountdown <= 0)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;

    }

    /// <summary>
    /// draws a space in order to see range fo the cannnon
    /// </summary>
   void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    /// <summary>
    /// shoots a bullet that is instantiated from a prefab
    /// seeks enemy out and follows it along the path
    /// </summary>
    void Shoot()
    {
       GameObject bulletGO = (GameObject) Instantiate ( bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

       
        if ( bullet != null )
        {
            bullet.Seek(target);
        }
        Debug.Log("SHOOT!");
    }
}
