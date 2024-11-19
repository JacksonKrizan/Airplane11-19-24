using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
//video 2D Shooting in Unity (Tutorial)
public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    
    public float bulletSpeed = 10;
    public bool bulletSpawn = true;
    public float bulletSpawnDelay;
    public Light2D Light;
    public Light2D Light2;
    public Light2D Light3;
    public bool ammo;
    public int bulletCount;
    public Text txtBullets;
    void Start()
    {
        Light.intensity = 0f;
        Light2.intensity = 0f;
        Light3.intensity = 0f;

    }

    void Update()
    {
        //txtBullets.text = "Bulets : " + bulletCount.ToString("F");
        //txtBullets.text = bulletCount.ToString("F");
        txtBullets.text = bulletCount.ToString("F0");
        if (ammo == true)
        {
            if (bulletSpawn == true)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Light.intensity = 100f;
                    Light2.intensity = 10f;
                    Light3.intensity = 2f;

                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
                    bulletSpawn = false;
                    bulletCount -= 1;
                    StartCoroutine(ShootBullets());
                }

            }

        }
        
        if (bulletCount <= 0)
        {
            ammo = false;

        }
        if (bulletCount >= 1)
        {
            ammo = true;

        }
    }

    
    IEnumerator ShootBullets()
    {
        if (bulletSpawn == false)
        {
            yield return new WaitForSeconds(.03f);
            Light.intensity = 0f;
            Light2.intensity = 0f;
            Light3.intensity = 0f;
            yield return new WaitForSeconds(bulletSpawnDelay);
            bulletSpawn = true;
            Debug.Log("pew pew");
        }

    }
}
