using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BomberSpawner : MonoBehaviour
{
    public GameObject bomberPrefab;
    public Transform bomberSpawnPoint;
    Vector2 whereToSpawn;
    public int randomY;
    public float axisX;
    public float bomberDelay;
    public float bomberDelay2;
    public bool bomberSpawn = false;
    public bool firstBomberSpawnDelay = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (firstBomberSpawnDelay == true)
        {
            if (bomberSpawn == true)
            {
                bomberSpawn = false;
                randomY = Random.Range(4, 8);
                //randomY = randomY * 10;
                axisX = 15;
                whereToSpawn = new Vector2(axisX, randomY);
                Instantiate(bomberPrefab, whereToSpawn, Quaternion.identity);

                StartCoroutine(bomberSpawnDelay());
            }
            IEnumerator bomberSpawnDelay()
            {
                if (bomberSpawn == false)
                {
                    yield return new WaitForSeconds(bomberDelay);
                    bomberSpawn = true;
                }

            }
        }
        else 
        {
            StartCoroutine(StartBombingRun());
        }
        IEnumerator StartBombingRun()
        {
            yield return new WaitForSeconds(bomberDelay2);
            firstBomberSpawnDelay = true;
        }
    }

}
