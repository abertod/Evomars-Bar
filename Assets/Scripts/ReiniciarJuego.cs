using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReiniciarJuego : MonoBehaviour
{
    
    public Bebida_Picante bebidaPicante;
    public Bebida_Dulce bebidaDulce;
    public Bebida_Acido bebidaAcido;
    public ObjetosSeleccionables objetosSeleccionables;

    public TMP_Text[] textosPulsaciones;
    public TMP_Text textoConsola;

    public Sprite cuadradoLleno;
    public Sprite cuadradoVacio;

    void Start()
    {
        
        textoConsola = GameObject.Find("TextoConsola").GetComponent<TMP_Text>();
        //Texto de las últimas 5 botellas pulsadas
        textosPulsaciones = new TMP_Text[5];
        for (int i = 0; i < 5; i++)
        {
            textosPulsaciones[i] = GameObject.Find("Texto" + (i + 1)).GetComponent<TMP_Text>();
        }

        objetosSeleccionables = GameObject.Find("Bebida_1").GetComponent<ObjetosSeleccionables>();
    }

    public void Reiniciar()
    {
        //Reinicio de las sumas
        objetosSeleccionables.sumaTotal = 0;
        objetosSeleccionables.sumaPicante = 0;
        objetosSeleccionables.sumaDulce = 0;
        objetosSeleccionables.sumaAcido = 0;

        //Reiniciar la cuenta de pulsaciones y permitir nuevas pulsaciones. Maximo 5
        ObjetosSeleccionables.contadorPulsaciones = 0;
        ObjetosSeleccionables.permitirNuevasPulsaciones = true;

        //Limpiar la lista de pulsaciones recientes
        ObjetosSeleccionables.pulsacionesRecientes.Clear();

        //Limpiar los textos de pulsaciones
        for (int i = 0; i < textosPulsaciones.Length; i++)
        {
            textosPulsaciones[i].text = "";
        }

        //Limpiar el texto de la consola de depués de 5 pulsaciones
        textoConsola.text = "";

        //Reiniciar los cuadrados de la barra 
        RellenarCuadrados(bebidaPicante.picanteCuadrados, 0);
        RellenarCuadrados(bebidaDulce.dulceCuadrados, 0);
        RellenarCuadrados(bebidaAcido.acidoCuadrados, 0);

        //Reiniciar los valores en los scripts de las botellas
        bebidaPicante.Reiniciar();
        bebidaDulce.Reiniciar();
        bebidaAcido.Reiniciar();
        //objetosSeleccionables.Reiniciar();

        Debug.Log("El juego ha sido reiniciado.");
    }

    void RellenarCuadrados(SpriteRenderer[] cuadrados, int cantidad)
    {
        for (int i = 0; i < cuadrados.Length; i++)
        {
            if (i < cantidad)
            {
                cuadrados[i].sprite = cuadradoLleno;
            }
            else
            {
                cuadrados[i].sprite = cuadradoVacio;
            }
        }
    }
}
