using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RegistroPulsaciones : MonoBehaviour
{
    public TMP_Text textoConsola;

    void Start()
    {
        textoConsola = GameObject.Find("TextoConsola").GetComponent<TMP_Text>();
    }

    void Update()
    {
        //Si las pulsaciones llegan a 5 se muestra este mensaje
        if (ObjetosSeleccionables.contadorPulsaciones >= 5)
        {
            ObjetosSeleccionables.permitirNuevasPulsaciones = false;
            textoConsola.text = "Ya has combinado cinco bebidas.";
        }
    }

    public void MostrarPulsacionesConsola()
    {
        if (ObjetosSeleccionables.contadorPulsaciones == 0)
        {
            textoConsola.text = "No se han registrado pulsaciones aún.";
            return;
        }

        textoConsola.text = "Pulsaciones registradas:\n";
        for (int i = 0; i < ObjetosSeleccionables.pulsacionesRecientes.Count; i++)
        {
            textoConsola.text += "Pulsación " + (i + 1) + ": " + ObjetosSeleccionables.pulsacionesRecientes[i] + "\n";
        }
    }
}
