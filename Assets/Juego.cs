using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juego : MonoBehaviour
{
    public Transform objetivosObj;
    public bool usarObjetivos;
    public int objetivos, totalObjetivos;
    public Text texto;

    private void Start()
    {
        if (usarObjetivos)
            totalObjetivos = objetivosObj.childCount;
    }

    private void Update()
    {
        texto.text = "Objetivos: " + objetivos.ToString("") + "/" + totalObjetivos.ToString("");
    }
}

