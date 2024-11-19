using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    Rigidbody2D RB;
    public float bomberSpeed;
    //public int bomberAtBase;


    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        RB.AddForce(Vector2.left * bomberSpeed);
        

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(this.gameObject);

        }

        if (collision.gameObject.CompareTag("BomberPassed"))
        {
            Destroy(this.gameObject);
            Debug.Log("BomberPassed");
        //    bomberAtBase += 1;
            
        }
    }
}
