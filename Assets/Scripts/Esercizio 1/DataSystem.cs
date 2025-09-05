using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataSystem : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private Slider _brightnessSlider;
    [SerializeField] private Toggle _fullScreenToggle;

    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat(PlayerPrefsKeys.Volume, _volumeSlider.value);
        PlayerPrefs.SetFloat(PlayerPrefsKeys.Brightness, _brightnessSlider.value);
        PlayerPrefs.SetInt(PlayerPrefsKeys.FullScreen, _fullScreenToggle.isOn ? 1 : 0);
    }

    public void Load()
    {
        _volumeSlider.value = PlayerPrefs.GetFloat(PlayerPrefsKeys.Volume, .5f); // <- se non usassi l'override con il valore di default, dovrei fare un check prima del Get
        _brightnessSlider.value = PlayerPrefs.GetFloat(PlayerPrefsKeys.Brightness, .5f);
        _fullScreenToggle.isOn = PlayerPrefs.GetInt(PlayerPrefsKeys.FullScreen, 0) == 1 ? true : false;
    }
}
