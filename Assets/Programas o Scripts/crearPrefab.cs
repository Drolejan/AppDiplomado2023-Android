using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class crearPrefab : MonoBehaviour
{
    public GameObject prefabAcrear;
    public GameObject contenedorPrefab;
    public TMP_InputField inputNombre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void crear()//Crea el prefab elegido en el contenedor
    {
       GameObject doc = Instantiate(prefabAcrear,contenedorPrefab.transform);
       doc.transform.Find("DocName").GetComponent<TextMeshProUGUI>().text = inputNombre.text;
    }
}
