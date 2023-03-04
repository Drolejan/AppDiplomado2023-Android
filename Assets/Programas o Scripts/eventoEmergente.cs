using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eventoEmergente : MonoBehaviour
{
    public TMP_InputField nombre;
    public TMP_InputField hora;
    public CalendarManager datos;
    public TextMeshProUGUI fecha;
    public GameObject eventoPrefab;
    public GameObject contenedorEventos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void crear()// El comando "\n" sirve para insertar un salto de linea
    {
        //Aqui se crea el evento en el calendario
        string evento = datos.fecha + "\n" + nombre.text + "\n" + hora.text;
        PlayerPrefs.SetString(datos.fecha, evento);//Para guardar el evento
        fecha.text = evento;

        //Aca abajo se crea el prefab para la pantalla de proximos eventos
        GameObject nuevoEvento = Instantiate(eventoPrefab,contenedorEventos.transform);
        //string fragmento = evento.Substring(0,100) +"...";
        //nuevoEvento.GetComponentInChildren<TextMeshProUGUI>().text = fragmento;
        nuevoEvento.GetComponentInChildren<TextMeshProUGUI>().text = evento;
    }
}
