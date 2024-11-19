using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public SpikeGenerator spikeGenerator;

    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            spikeGenerator.GernerateNextSpikeWithGap();
            //Debug.Log("Spike collided with spike");
        }

        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
            //Debug.Log("Spike collided with Finish");
        }
    }


}
