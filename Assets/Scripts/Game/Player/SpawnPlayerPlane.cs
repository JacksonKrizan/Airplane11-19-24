using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerPlane : MonoBehaviour
{
    [SerializeField] GameObject F15;
    [SerializeField] GameObject P51;
    [SerializeField] GameObject Corsair;
    [SerializeField] GameObject F16;
    public Transform playerSpawnPoint;
    public static int planeTypeVar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(planeTypeVar);
    }
}
