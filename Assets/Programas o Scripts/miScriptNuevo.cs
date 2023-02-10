using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miScriptNuevo : MonoBehaviour
{
    // Reglas para nombrar scripts o fragmentos de código
    // 1. No espacios
    // 2. No acentos
    // 3. No comenzar con valores numericos 
    // IMPORTANTE: El nombre del archivo tiene que coincidir con el nombre
    // de la public class


    void Start()
    {
        Debug.Log("Hola!");
    }

    // Vamos a modificar este update por nuestra función botonazo
    public void botonazo()
    {
       Debug.Log("Boton presionado, éxito!");
    }

}
