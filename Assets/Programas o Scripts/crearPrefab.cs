using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearPrefab : MonoBehaviour
{
    public GameObject prefabAcrear;
    public GameObject contenedorPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void crear()//Crea el prefab elegido en el contenedor
    {
       Instantiate(prefabAcrear,contenedorPrefab.transform);
    }
}
