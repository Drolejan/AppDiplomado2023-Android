using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class calificar : MonoBehaviour
{
    public TextMeshProUGUI textoPromedio;
    public GameObject contenedorRankings;
    public etiquetaRanking[] encendidos;
    public int calificacion;
    // Start is called before the first frame update
    void Start()
    {
        /*
        encendidos=contenedorRankings.GetComponentsInChildren<etiquetaRanking>();
        for (int i = 0; i < encendidos.Length; i++)
        {
            encendidos[i].gameObject.SetActive(false);
        }
        */
    }

    public void sumarYpromediar(float c)
    {
        int indiceEncendidos = (int)c;
        for (int i = 0; i < indiceEncendidos; i++)
        {
            encendidos[i].gameObject.SetActive(true);
        }

        float promedioActual = float.Parse(textoPromedio.text);
        float calificacion = c;
        float nuevoPromedio = (promedioActual + calificacion) / 2;
        textoPromedio.text = nuevoPromedio.ToString();
    }

    /*
    private void OnMouseOver()
    {
        for (int i = 0; i < calificacion; i++)
        {
            encendidos[i].gameObject.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        for (int i = 0; i < encendidos.Length; i++)
        {
            encendidos[i].gameObject.SetActive(false);
        }
    }
    */
}
