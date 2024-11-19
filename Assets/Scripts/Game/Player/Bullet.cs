using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
 
    void Awake()
    {
        Destroy(gameObject, life);
    }
 
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.CompareTag("BulletEnd"))
        {
            Destroy(this.gameObject);
            
        }
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(this.gameObject);
            
        }

    }

}
