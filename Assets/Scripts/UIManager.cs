using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _settingScreen;
    public GameObject _informationScreen;
    public GameObject _backButton;

    private void Start()
    {
        _settingScreen.SetActive(false);
        _backButton.SetActive(false);
        _informationScreen.SetActive(false);
    }

    public void AugmentedReality()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
       
    }

    public void Information()
    {

    }

    public void Quiz()
    {
        SceneManager.LoadScene(2);
    }

    public void Back()
    {
        if(_mainMenu.activeInHierarchy == true)
        {

        }
    }
}
