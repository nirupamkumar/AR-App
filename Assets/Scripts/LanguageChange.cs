using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LanguageChange : MonoBehaviour
{
    public Toggle toggle;

    public void LanguageToggleSwitch(int localId)
    {
        if (toggle == true)
        {
            StartCoroutine(SetLocal(localId));
        }

    }

    IEnumerator SetLocal(int localID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localID];
    }
}
