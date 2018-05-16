using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niveles : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;    
    }

    public void CargarNivel (int nivel)
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(nivel);
    }

    public void SalirDelJuego ()
    {
        Application.Quit();
    }
}
