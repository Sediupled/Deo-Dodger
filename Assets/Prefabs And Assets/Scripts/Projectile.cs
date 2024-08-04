using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{



    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);

        if (col.gameObject.CompareTag("Enemy"))
        {
            Health hp = col.gameObject.GetComponent<Health>();
            if (hp != null)
            {
                hp.HealthSelect(1);
                Debug.Log(hp.HealthBar);
                if (hp.HealthBar <= 0)
                {
                    Destroy(col.gameObject);
                }
            }
            else
            {
                Debug.LogError("Health component not found on the enemy");
            }

        }
    }
    








}
