using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLink : MonoBehaviour
{
    public string link;//El link lo colocaremos en el boton de Unity
    public void abrir()
    {
        Application.OpenURL(link);
    }

}
