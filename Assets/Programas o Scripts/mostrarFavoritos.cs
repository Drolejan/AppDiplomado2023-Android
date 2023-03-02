using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrarFavoritos : MonoBehaviour
{

    public favoritos[] listaFav;
    void Start()
    {
        listaFav=GetComponentsInChildren<favoritos>();
    }

    public void activarFavoritos()
    {
        for (int i = 0; i < listaFav.Length; i++)
        {
            listaFav[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < listaFav.Length; i++)
        {
            if (listaFav[i].esFavorito)
            {
                listaFav[i].gameObject.SetActive(true);
            }
        }
    }
}
