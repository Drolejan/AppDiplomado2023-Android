using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class guardarDatos : MonoBehaviour
{
    public TMP_InputField cajaTexto;//Esta es mi caja de texto
    public string textoDocumento;//Este es solamente mi texto
    public TextMeshProUGUI nombreDocumento;
    void Start()
    {
        //
    }

    public void saveDatos()
    {
        textoDocumento = cajaTexto.text;//Leo y asigno lo que se escribe en el input
        Debug.Log(textoDocumento);
        PlayerPrefs.SetString(nombreDocumento.text, textoDocumento);
    }

    public void loadDatos()
    {
        string datosCargados = PlayerPrefs.GetString(nombreDocumento.text);
        Debug.Log(datosCargados);
        cajaTexto.text = datosCargados;//Actualizo la caja de texto
    }

}
