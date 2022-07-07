using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LanguageChange : MonoBehaviour
{
    public Toggle toggle;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
     
        //DontDestroyOnLoad(this.gameObject);
    }

    public void LanguageToggleSwitch(int localId)
    {
        if (toggle.isOn == true)
            StartCoroutine(SetLocal(localId));
        else
            StartCoroutine(SetLocal(0));
    }

    IEnumerator SetLocal(int localID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localID];
    }
}
