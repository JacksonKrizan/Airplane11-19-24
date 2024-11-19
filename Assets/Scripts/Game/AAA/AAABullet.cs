using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAABullet : MonoBehaviour
{
    public float life = 3;
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2 (direction.x, direction.y).normalized * force;
    }
    void Awake()
    {
        Destroy(gameObject, life);
    }
 
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.CompareTag("BulletEnd"))
        {
            Destroy(this.gameObject);
            //Debug.Log("Spike collided with Finish");
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            //Debug.Log("Spike collided with Finish");
        }
        if(collision.gameObject.CompareTag("spike"))
        {
            Destroy(this.gameObject);
            //Debug.Log("Spike collided with Finish");
        }
    }

}
