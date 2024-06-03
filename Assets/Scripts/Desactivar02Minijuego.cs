using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar02Minijuego : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    // Color más transparente al pasar el ratón
    public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 

    public GameObject pantallaMinijuego;

    
    public ApareceBebidasKoemi apareceBebidasKoemi;

    public ReiniciarJuego reiniciarJuego;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;

        pantallaMinijuego = GameObject.Find("Minijuego_2");
    }

    void OnMouseDown()
    {
        //Esta función se activará cuando el jugador haga clic en la imagen
        Seleccionar();
    }

    void OnMouseEnter()
    {
        //Cuando el ratón entra en el objeto
        spriteRenderer.color = colorAlPasarElRaton;
    }

    void OnMouseExit()
    {
        //Cuando el ratón sale del objeto
        spriteRenderer.color = colorOriginal;
    }

    
    void Seleccionar()
    {
        //Aquí se realizará la selección
        Debug.Log("Imagen seleccionada: " + gameObject.name);
        pantallaMinijuego.SetActive(false);
        apareceBebidasKoemi.timearAparicion = 0;
        apareceBebidasKoemi.empiezaContar02 = false;
        apareceBebidasKoemi.prepBebida05.SetActive(false);
        apareceBebidasKoemi.prepBebida06.SetActive(false);
        apareceBebidasKoemi.prepBebida07.SetActive(false);
        apareceBebidasKoemi.prepBebida08.SetActive(false);

        reiniciarJuego.Reiniciar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
