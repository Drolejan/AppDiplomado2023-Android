using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class calificar : MonoBehaviour
{
    public TextMeshProUGUI textoPromedio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void sumarYpromediar(float c)
    {
        float promedioActual = float.Parse(textoPromedio.text);
        float calificacion = c;
        float nuevoPromedio = (promedioActual + calificacion) / 2;
        textoPromedio.text = nuevoPromedio.ToString();
    }
}
