using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irAubicacion : MonoBehaviour
{
    public AbstractMap miMapa;
    public string ubicacion;

    public void ir()
    {
        miMapa.SetCenterLatitudeLongitude(Conversions.StringToLatLon(ubicacion));
        miMapa.UpdateMap();
    }
}
