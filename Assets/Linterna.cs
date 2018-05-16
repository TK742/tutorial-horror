using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    public bool regenerarBateria;
    float bateria;
    public float bateriaMaxima;
    public GameObject luz;
    public Text texto;

    private void Start()
    {
        bateria = Mathf.Abs(bateriaMaxima);
    }

    void Update()
    {
        texto.text = "Bateria: " + bateria.ToString("0") + "%";
        if (luz.activeSelf)
            bateria -= Time.deltaTime;
        else if (!luz.activeSelf && bateria < Mathf.Abs(bateriaMaxima) && regenerarBateria)
            bateria += Time.deltaTime;

        if (bateria <= 0)
            luz.SetActive(false);

        if(Input.GetKeyDown(KeyCode.F) && bateria > 0)
        {
            luz.SetActive(!luz.activeSelf);
            GetComponent<AudioSource>().Play();
        }
    }

    public void AgregarBateria (float bateriaRegenerada)
    {
        bateria += bateriaRegenerada;
        if (bateria >= bateriaMaxima)
            bateria = bateriaMaxima;
    }
}
