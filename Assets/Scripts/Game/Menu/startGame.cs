using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//The 2 BEST Ways to Time DELAY a FUNCTION - Unity
public class startGame : MonoBehaviour
{
    public float timeWait;
    public bool deleteBlock = false;
    public Text countDown;
    public int countTXT;
    public GameObject WaitTxt;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
         StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1);
        countTXT -= 1;
        StartCoroutine(CountDown());
        
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(timeWait);
        deleteBlock = true;
    }
    
    void Update()
    {

         countDown.text = "" + countTXT;
        if (deleteBlock == true)
        {
            Destroy(this.gameObject);

        }

        if (countTXT == 0)
        {

            countDown.text = " ";
        }


    }


}
