using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/*
 * Author: [Fain, Jewel ; Gibson,Hannah]
 * Last Updated: [12/08/2023]
 * [Handles bullet mechanics]
 */
public class Bullet : MonoBehaviour
{

    private Transform target;


    public float speed = 70f;

    public int damage = 1;

    public void Seek(Transform Target1)
    {
        target = Target1;
    }


    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceOfBullet = speed * Time.deltaTime;

        if (dir.magnitude <= distanceOfBullet)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceOfBullet, Space.World);
    }

    /// <summary>
    /// handles hitting enemies and destroys bullet when it collides
    /// </summary>
    void HitTarget()
    {
        Damage(target);
        Destroy(gameObject);
        Debug.Log("Hit something");
    }

    /// <summary>
    /// handles damage dealt
    /// </summary>
    /// <param name="enemy">enemy in other script</param>
    public void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }


    }


}
