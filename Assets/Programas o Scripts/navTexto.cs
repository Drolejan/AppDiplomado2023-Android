using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class navTexto : MonoBehaviour
{
    //Estas 2 variables nos serviran para navegar entre todas las pantallas
    public GameObject miCanvas;
    public RectTransform posPantallaTexto;
    public RectTransform posPantallaDocumentos;
    public guardarDatos codigoDatos;
    public TextMeshProUGUI docAbierto;
    Vector2 posInicial;
    //Al inicio guardamos la posición de nuestra pantalla
    void Start()
    {
        codigoDatos = GameObject.Find("CodigoDatos").GetComponent<guardarDatos>();
        miCanvas = GameObject.Find("Canvas");
        posPantallaTexto = miCanvas.transform.Find("Pantalla Texto").GetComponent<RectTransform>();
        posPantallaDocumentos = miCanvas.transform.Find("Pantalla Documentos").GetComponent<RectTransform>();
        
        posInicial = posPantallaTexto.anchoredPosition;
    }
    //Esta función sirve para mostrar la pantalla seleccionada
    public void entrarTexto()
    {
        posPantallaTexto.gameObject.SetActive(true);//Enciendo la pantalla
        posPantallaTexto.anchoredPosition = Vector2.zero;//La colocamos en posición
        codigoDatos.nombreDocumento = docAbierto;
        codigoDatos.loadDatos();
    }
    //Esta función sirve para ocultar la pantalla seleccionada
    public void salirTexto()
    {
        posPantallaDocumentos.gameObject.SetActive(false);//Apaga la pantalla documentos                                            
    }
}
