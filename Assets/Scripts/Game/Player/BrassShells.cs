using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrassShells : MonoBehaviour
{
    
    [SerializeField] private ParticleSystem testParticleSystem = default;
    public float TimeWait;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            testParticleSystem.Play();
            //Debug.Log("Particle System Playing");
        }
        else
        {
            Invoke ("TurnParticleOff", TimeWait);   
            //Debug.Log("Particle system is off");
        }

    
        /*
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            testParticleSystem.Stop();
        }
        */
    }

    void TurnParticleOff ()
    {
        if (testParticleSystem != null)
        {
            testParticleSystem.Stop();
        }
    }
    
}
