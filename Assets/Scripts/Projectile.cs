using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);


        Health hp = other.gameObject.GetComponent<Health>();
        if (hp != null)
        {
            hp.HealthSelect(1);
            Debug.Log(hp.HealthBar);
            if (hp.HealthBar <= 0)
            {
                Destroy(other.gameObject);
            }
        }
        else
        {
            Debug.LogError("Health component not found on the enemy");
        }
    }

}
