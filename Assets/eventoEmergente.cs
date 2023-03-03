using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eventoEmergente : MonoBehaviour
{
    public TMP_InputField nombre;
    public TMP_InputField hora;
    public TextMeshProUGUI fecha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void crear()// El comando "\n" sirve para insertar un salto de linea
    {
        string evento = fecha.text + "\n" + nombre.text + "\n" + hora.text;
        fecha.text = evento;     
    }
}
