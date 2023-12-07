using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;

    public float speed = 70f;
    public void Seek(Transform Target1)
    {
        target = Target1;
    }
   

    // Update is called once per frame
    void Update()
    {
        if ( target == null)
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

    void HitTarget()
    {
        Destroy(target.gameObject);
        Destroy(gameObject);
        Debug.Log("Hit something");
    }
}
