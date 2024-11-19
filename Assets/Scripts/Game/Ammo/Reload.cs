using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public GameObject bulletCartridge;
    public bool bulletCartridgeEnabled;
    public int bulletCartridgeX;
    public int bulletCartridgeY;
    Vector2 bulletCartridgeSpawn;
    public float bulletCartridgeDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletCartridgeEnabled == true)
        {
            bulletCartridgeEnabled = false;
            bulletCartridgeX = Random.Range(-8, 0);
            bulletCartridgeY = 15;
            bulletCartridgeSpawn = new Vector2(bulletCartridgeX, bulletCartridgeY);
            Instantiate(bulletCartridge, bulletCartridgeSpawn, Quaternion.identity);

            StartCoroutine(bomberSpawnDelay());
        }
        IEnumerator bomberSpawnDelay()
        {
            if (bulletCartridgeEnabled == false)
            {
                yield return new WaitForSeconds(bulletCartridgeDelay);
                bulletCartridgeEnabled = true;
            }

        }
    }
}

