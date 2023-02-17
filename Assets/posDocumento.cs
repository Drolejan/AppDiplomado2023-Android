using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posDocumento : MonoBehaviour
{
    RectTransform posMiDocumento;//la posición del icono de documento
    public RectTransform posOrigen;//la posición para visualizar y leer el documento.
    void Start()
    {
        posMiDocumento= GetComponent<RectTransform>();//Obtengo la posición inicial
    }
   
    public void posicionar()
    {
        posMiDocumento.anchoredPosition = posOrigen.anchoredPosition;
    }
}
