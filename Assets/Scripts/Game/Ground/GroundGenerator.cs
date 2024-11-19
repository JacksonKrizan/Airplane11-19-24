
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    public float randomWait;
    public float SpeedMultiplier;
    
    void Awake()
    {
        currentSpeed = MinSpeed;
        gernerateSpike();
    }

    public void GernerateNextSpikeWithGap()
    {
        Invoke("gernerateSpike", randomWait);
    }
     void gernerateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }

    void Update()
    {
        //if (currentSpeed < MaxSpeed)
        //{
        //    currentSpeed += SpeedMultiplier;
        //}
    }
}
