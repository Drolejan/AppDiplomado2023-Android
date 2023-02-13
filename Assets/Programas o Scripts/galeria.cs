using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class galeria : MonoBehaviour
{
    public GameObject contenedorGaleria;//Aqui se guardan nuestros elementos
    public RectTransform[] elementosGaleria;//Esto es una arreglo(lista) de los elementos
    public int indice;//Este es el numero del elemento activo en pantalla
    void Start()
    {//Metodo 1: Buscando los elementos del contenedor
        elementosGaleria = contenedorGaleria.GetComponentsInChildren<RectTransform>();
        indice = 1;
        actualizarGaleria();
    }

    void actualizarGaleria()
    {//Usaremos un ciclo para apagar todos los elementos de la Galeria
        for (int i = 1; i < elementosGaleria.Length; i++)
        {
            elementosGaleria[i].gameObject.SetActive(false);
        }
        //Encendemos solamente el del indice
        elementosGaleria[indice].gameObject.SetActive(true);
    }

    public void siguiente()
    {
        if (indice < elementosGaleria.Length - 1)
        {
            indice++;
        }
        else
        {
            indice = 1;
        }
        actualizarGaleria();
    }

    public void anterior()
    {
        if (indice > 1)
        {
            indice--;
        }
        else
        {
            indice = elementosGaleria.Length-1;
        }
        actualizarGaleria();
    }

}
