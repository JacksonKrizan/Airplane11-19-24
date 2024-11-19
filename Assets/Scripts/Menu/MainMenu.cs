using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField]int mainMenu;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(mainMenu);

    }

}