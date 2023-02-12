using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrusel : MonoBehaviour
{
    public GameObject elementosCarrusel;
    public RectTransform[] objetos;
    public int indice = 1;
    void Start()
    {
        //Application.OpenURL("https://github.com/");
        objetos = elementosCarrusel.GetComponentsInChildren<RectTransform>();

        actualizarCarrusel(); 
    }

    public void actualizarCarrusel()
    {
        for (int i = 1; i < objetos.Length; i++)
        {
            objetos[i].gameObject.SetActive(false);
        }
        objetos[indice].gameObject.SetActive(true);
    }

    public void siguiente()
    {
        if(indice<objetos.Length-1)
        {
            indice++;
        }
        else
        {
            indice = 1;
        }
        actualizarCarrusel();
    }

    public void anterior()
    {
        if (indice > 1)
        {
            indice--;
        }
        else
        {
            indice = objetos.Length-1;
        }
        actualizarCarrusel();
    }
}
