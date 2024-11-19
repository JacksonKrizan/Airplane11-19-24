using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinChocie : MonoBehaviour
{
    [SerializeField] GameObject F15;
    [SerializeField] GameObject P51;
    [SerializeField] GameObject Corsair;
    [SerializeField] GameObject F16;
    
    public static int planeTypeVar;
    public void F15Skins()
    {
        planeTypeVar = 1;

    }
    public void P51Skin()
    {
        planeTypeVar = 2;

    }

    public void CorsairSkin()
    {
        planeTypeVar = 3;

    }
    public void F16Skin()
    {
        planeTypeVar = 4;

    }
    void Update()

    {
        //Debug.Log(planeTypeVar);

    }
        
    
}

