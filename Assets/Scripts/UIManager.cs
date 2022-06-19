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
        _settingScreen.SetActive(true);
        _backButton.SetActive(true);

        _mainMenu.SetActive(false);
        _informationScreen.SetActive(false);
    }

    public void Information()
    {
        _informationScreen.SetActive(true);
        _backButton.SetActive(true);

        _mainMenu.SetActive(false);
        _settingScreen.SetActive(false);
    }

    public void Quiz()
    {
        SceneManager.LoadScene(2);
    }

    public void Back()
    {
        _mainMenu.SetActive(true);

        _backButton.SetActive(false);  
        _settingScreen.SetActive(false);
        _informationScreen.SetActive(false);
    }
}
