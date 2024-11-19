using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BomberPassed : MonoBehaviour
{
    public int bomberAtBase;
    [SerializeField] Text bomberMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bomberMessage.text = bomberAtBase.ToString("F0");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Bomber"))
        {
            bomberMessage.text = "Bombers Passed : " + bomberAtBase.ToString("F");
            bomberAtBase += 1;

        }
    }
}
