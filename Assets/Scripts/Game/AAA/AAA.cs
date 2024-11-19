using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class AAA : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public Light2D Light1;
    public Light2D Light2;
    public Light2D Light3;
    public Light2D Light4;
    public float bulletSpeed = 10;
    public bool bulletSpawn = false;
    public bool bulletSpawnStart = true;
    public float bulletSpawnDelay;
    public float antiReload = 0;
    public bool AAAReload = true;
    void Start()
    {
        Light1.intensity = 0f;
        Light2.intensity = 0f;
        Light3.intensity = 0f;
        Light4.intensity = 0f;
    }

    void Update()
    {
        if (AAAReload == true)
        {
            

            if (bulletSpawnStart == false)
            {
                if (bulletSpawn == true)
                {

                    Light1.intensity = 30f;
                    Light2.intensity = 30f;
                    Light3.intensity = 70f;
                    Light4.intensity = 3f;
                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
                    bulletSpawn = false;
                    StartCoroutine(ShootBullets());
                    antiReload += 1;


                }
            }
            else
            {
                StartCoroutine(ShootBulletsBeforeStart());
            }


        }

        if (antiReload >= 5)
        {
            AAAReload = false;
            
            StartCoroutine(ReloadingTruck());
        }
    }

    IEnumerator ReloadingTruck()
    {
        yield return new WaitForSeconds(10);
        antiReload = 0;
        AAAReload = true;
    }
    IEnumerator ShootBulletsBeforeStart()
    {
        if (bulletSpawnStart == true)
        {
            yield return new WaitForSeconds(5);
            bulletSpawnStart = false;
        }

    }
    IEnumerator ShootBullets()
    {

            if (bulletSpawn == false)
            {
                yield return new WaitForSeconds(.05f);
                Light1.intensity = 0f;
                Light2.intensity = 0f;
                Light3.intensity = 0f;
                Light4.intensity = 0f;
                yield return new WaitForSeconds(bulletSpawnDelay);
                bulletSpawn = true;

            }



    }


}
