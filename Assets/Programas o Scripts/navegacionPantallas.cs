using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class navegacionPantallas : MonoBehaviour
{
    //Estas 2 variables nos serviran para navegar entre todas las pantallas
    public RectTransform posNextPantalla;
    Vector2 posInicial;
    //Al inicio guardamos la posici�n de nuestra pantalla
    void Start()
    {
        posInicial = posNextPantalla.anchoredPosition;      
    }
    //Esta funci�n sirve para mostrar la pantalla seleccionada
    public void entrarPantalla()
    {
        posNextPantalla.gameObject.SetActive(true);//Enciendo la pantalla
        posNextPantalla.anchoredPosition = Vector2.zero;//La colocamos en posici�n
    }
    //Esta funci�n sirve para ocultar la pantalla seleccionada
    public void salirPantalla()
    { 
        transform.parent.gameObject.SetActive(false);//Apaga la pantalla actual                                             
    }
}
