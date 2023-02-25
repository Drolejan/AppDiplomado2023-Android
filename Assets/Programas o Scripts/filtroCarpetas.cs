using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filtroCarpetas : MonoBehaviour
{
    public GameObject contenedorDocs;
    public etiquetaDocumento[] allDocuments;
    public etiquetaMisterio[] docsFiltrados;
    // Start is called before the first frame update
    void Start()
    {
        allDocuments= contenedorDocs.GetComponentsInChildren<etiquetaDocumento>();
        docsFiltrados= contenedorDocs.GetComponentsInChildren<etiquetaMisterio>();
    }

    public void apagarTodos()
    {
        for (int i = 1; i < allDocuments.Length; i++)
        {
            allDocuments[i].gameObject.SetActive(false);
        }
    }

    public void filtrarMisterio()
    {
        for (int i = 0; i < docsFiltrados.Length; i++)
        {
            docsFiltrados[i].gameObject.SetActive(true);
        }
    }
}
