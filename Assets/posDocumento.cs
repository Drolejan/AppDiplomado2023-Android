using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posDocumento : MonoBehaviour
{
    RectTransform posMiDocumento;//la posici�n del icono de documento
    public RectTransform posOrigen;//la posici�n para visualizar y leer el documento.
    void Start()
    {
        posMiDocumento= GetComponent<RectTransform>();//Obtengo la posici�n inicial
    }
   
    public void posicionar()
    {
        posMiDocumento.anchoredPosition = posOrigen.anchoredPosition;
    }
}
