using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAI : MonoBehaviour
{
    public GameObject eulerAngles;
    public float degrees;
    public bool RotationAv;
    public float rotationSpeed;
    void Update()
    {


        if (RotationAv == true)
        {
            this.transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
            StartCoroutine(RotateA());

        }

        if (RotationAv == false)
        {
            this.transform.Rotate(Vector3.forward, +rotationSpeed * Time.deltaTime);
            StartCoroutine(RotateB());

        }
    }



    IEnumerator RotateA()
    {

        yield return new WaitForSeconds(degrees);
        RotationAv = false;

    }
    IEnumerator RotateB()
    {

        yield return new WaitForSeconds(degrees);
        RotationAv = true;

    }

}
