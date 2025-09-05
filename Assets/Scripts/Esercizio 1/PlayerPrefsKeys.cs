using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsKeys // <- uso una classe statica per gestire i PlayerPrefs
{
    public const string Volume = "Volume"; // <- una variabile const � automaticamente static
    public const string Brightness = "Brightness";
    public const string FullScreen = "FullScreen";
}
