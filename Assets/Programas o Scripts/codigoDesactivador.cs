using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoDesactivador : MonoBehaviour
{
    public GameObject objetoPorDesactivar;//En Unity le asignaremos el objeto por desactivar

    // Función para desactivar
    public void desactivarObj()
    {
        objetoPorDesactivar.SetActive(false);
    }
}
