using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//Para usar textos e input fields

public class publicarComentario : MonoBehaviour
{
    public GameObject objetoPorDesactivar;//En Unity le asignaremos el objeto por desactivar
    public TMP_InputField inputUsuario;
    public TMP_InputField inputComentario;
    public GameObject prefabComentario;
    public GameObject contenedorComentarios;
    public void publicar()
    {
        if (inputComentario.text.Length>1)
        {
        GameObject miComentario = Instantiate(prefabComentario, contenedorComentarios.transform);
        miComentario.transform.Find("Usuario").GetComponent<TextMeshProUGUI>().text=inputUsuario.text;
        miComentario.transform.Find("Comentario").GetComponent<TextMeshProUGUI>().text=inputComentario.text;        
        miComentario.transform.Find("Fecha").GetComponent<TextMeshProUGUI>().text="18/02/23";        
        }

        desactivarObj();
        inputUsuario.text = "";
        inputComentario.text = "";
    }


    // Función para desactivar
    public void desactivarObj()
    {
        objetoPorDesactivar.SetActive(false);
    }
}
