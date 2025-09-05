using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // <- la rendo serializzabile
public class PlayerSave // <-  rimuovo MonoBehaviour poichè deve essere scollegata da qualsiasi componente
{
    public float[] position = new float[3];
    public float[] rotation = new float[4];

    public PlayerSave() { } // <- costruttore vuoto

    public PlayerSave(float[] position, float[] rotation) // <- override costruttore con parametri
    {
        this.position = position;
        this.rotation = rotation;
    }
}
