using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoActivador : MonoBehaviour
{
    public GameObject objetoPorActivar;//En Unity le asignaremos el objeto por activar
    
    // Funci�n para activar
    public void activarObj()
    {
        objetoPorActivar.SetActive(true);
    }
    
}
