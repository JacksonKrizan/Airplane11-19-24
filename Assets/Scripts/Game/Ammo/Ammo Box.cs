using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    public Gun addBullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        addBullets = FindObjectOfType<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.CompareTag("Player"))
        {
            addBullets.bulletCount += 25;
            
            Destroy(this.gameObject);
            
        }
        if (collision.gameObject.CompareTag("AmmoEnd"))
        {
            Destroy(this.gameObject);

        }


    }
}
