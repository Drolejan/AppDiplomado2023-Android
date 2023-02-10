using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class controlPaneles : MonoBehaviour
{
    string usuario;//Creamos una variable de texto llamada usuario
    string password;//En esta variable verificaremos el password

    Vector2 posInicialP2;//Creamos una variable de Vector2 para guardar una posición

    public RectTransform posPantalla2;//Creamos la variable posPantalla

    public TextMeshProUGUI mensajeInicial;//Creamos una variable de cuadro de texto
    public TextMeshProUGUI textoUsuario;//De esta variable tomaremos el input del usuario
    public TextMeshProUGUI instrucciones;//En esta variable mandaremos nuestros mensajes de error
    public TextMeshProUGUI textoPassword;

    //Creamos variables del input para borrar su contenido cuando lo necesitemos
    public TMP_InputField inputUsuario;
    public TMP_InputField inputPassword;
    
    // El start se ejecuta una sola vez
    void Start()
    {
        //Al comenzar el programa voy a guardar mi posición inicial
        posInicialP2 = posPantalla2.anchoredPosition;
    }

    //Función conectada al boton Register
    public void Register()
    {
        //Si el usuario tiene mas de 1 caracter y el password mas de 8
        if(textoUsuario.text.Length > 1 && textoPassword.text.Length > 8)
        {
            usuario = textoUsuario.text;//Guardamos el usuario
            password = textoPassword.text;//Guardamos el password
            instrucciones.text = "El Registro Fue Completado";
        }
        else
        {
            instrucciones.text = "Error, intentalo de nuevo";
        }
        
    }

    //Función conectada al boton Login
    public void LogIn()
    {
        if (usuario==textoUsuario.text && password==textoPassword.text)
        {
            //Esta linea manda mi pantalla a la posición (0,0)
            posPantalla2.anchoredPosition = Vector2.zero;
            
            mensajeInicial.text = "Esto es una prueba " + usuario + ", adelante:";
        }
        else
        {
            instrucciones.text = "Usuario o Password Incorrectos :(";
            Debug.Log("ERROR");
        }
    }

    //Función conectada al boton Cerrar Sesión
    public void Salir()
    {
        //Esta linea manda mi pantalla a su posición original
        posPantalla2.anchoredPosition = posInicialP2;
        instrucciones.text = "Por favor inicia sesión o registrate en el boton de abajo";
        //Para borrar correctamente tuvimos que acceder al objeto del input y no al texto
        inputUsuario.text = "";
        inputPassword.text = "";
    }

    // El update se ejecuta todo el tiempo
    void Update()
    {
        
    }

}
