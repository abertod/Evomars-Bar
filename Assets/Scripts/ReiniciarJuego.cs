using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReiniciarJuego : MonoBehaviour
{
    
    public Bebida_Picante bebidaPicante;
    public Bebida_Dulce bebidaDulce;
    public Bebida_Acido bebidaAcido;
    public Bebida_Sweet bebidasweet;
    public ObjetosSeleccionables objetosSeleccionables;

    public TMP_Text[] textosPulsaciones;
    public TMP_Text textoConsola;

    //public Sprite cuadradoLleno;
    //public Sprite cuadradoVacio;


    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    // Color más transparente al pasar el ratón
    public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 
    public ApareceBebidas apareceBebidas;

    void Start()
    {
        
        textoConsola = GameObject.Find("TextoConsola").GetComponent<TMP_Text>();
        //Texto de las últimas 5 botellas pulsadas
        textosPulsaciones = new TMP_Text[5];
        for (int i = 0; i < 5; i++)
        {
            textosPulsaciones[i] = GameObject.Find("Texto" + (i + 1)).GetComponent<TMP_Text>();
        }

        objetosSeleccionables = GameObject.Find("Spicy").GetComponent<ObjetosSeleccionables>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;
    }

    void OnMouseDown()
    {
        //Esta función se activará cuando el jugador haga clic en la imagen
        //Seleccionar();
        //apareceBebidas.AparecenBebidas();
        //apareceBebidas.AparecenImagenesPreparación();
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[1]);

        Reiniciar();
    }

    void OnMouseEnter()
    {
        //Cuando el ratón entra en el objeto
        spriteRenderer.color = colorAlPasarElRaton;
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[0]);
    }

    void OnMouseExit()
    {
        //Cuando el ratón sale del objeto
        spriteRenderer.color = colorOriginal;
    }

    public void Reiniciar()
    {
        
        objetosSeleccionables.ReiniciarMiniJuego();

        //Limpiar los textos de pulsaciones
        for (int i = 0; i < textosPulsaciones.Length; i++)
        {
            textosPulsaciones[i].text = "";
        }

        //Limpiar el texto de la consola de depués de 5 pulsaciones
        textoConsola.text = "";


        //Reiniciar los valores en los scripts de las botellas
        bebidaPicante.Reiniciar();
        bebidaDulce.Reiniciar();
        bebidaAcido.Reiniciar();
        bebidasweet.Reiniciar();
        //objetosSeleccionables.Reiniciar();

        Debug.Log("El juego ha sido reiniciado.");
    }

   
}
