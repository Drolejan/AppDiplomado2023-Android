using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class favoritos : MonoBehaviour
{
    public bool esFavorito;
    public void activarFavorito()
    {
        esFavorito = !esFavorito;
    }
}
