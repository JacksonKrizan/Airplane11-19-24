using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] GameObject OptionsMenu;
    [SerializeField] GameObject Skins;
    public void Options()
    {
        OptionsMenu.SetActive(true);

    }
    public void Resume()
    {
        OptionsMenu.SetActive(false);

    }

    public void SkinsMenu()
    {
        Skins.SetActive(true);

    }
    public void ResumeSkins()
    {
        Skins.SetActive(false);

    }
}
