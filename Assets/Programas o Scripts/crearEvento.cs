using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class crearEvento : MonoBehaviour
{
    public GameObject objetoPorDesactivar;//En Unity le asignaremos el objeto por desactivar
    public TMP_InputField inputEvento;
    public TMP_InputField inputFecha;
    public TMP_InputField inputHora;
    public GameObject prefabEvento;
    public GameObject contenedorEventos;
    public void crear()
    {
        if (inputEvento.text.Length > 1)
        {
            GameObject miEvento = Instantiate(prefabEvento, contenedorEventos.transform);
            miEvento.transform.Find("Evento").GetComponent<TextMeshProUGUI>().text = inputEvento.text;
            miEvento.transform.Find("Fecha").GetComponent<TextMeshProUGUI>().text = inputFecha.text;
            miEvento.transform.Find("Hora").GetComponent<TextMeshProUGUI>().text = inputHora.text;
        }

        desactivarObj();
        inputEvento.text = "";
        inputFecha.text = "";
        inputHora.text = "";
    }


    // Función para desactivar
    public void desactivarObj()
    {
        objetoPorDesactivar.SetActive(false);
    }
}
