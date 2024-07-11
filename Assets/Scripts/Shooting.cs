using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletHolder;
    public Transform bulletPos;
    public float FireSpeed = 0.5f;

    void Update()
    {
        Bullet();
    }


    void Bullet()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Shoot(BulletHolder);

        }
    }




    void Shoot(GameObject b)
    {
        GameObject bullet = Instantiate(b, bulletPos.position, bulletPos.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(bulletPos.up * FireSpeed, ForceMode2D.Impulse);
        Destroy(bullet, 2f);
    }
}
