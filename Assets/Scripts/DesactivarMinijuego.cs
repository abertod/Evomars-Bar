using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarMinijuego : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    // Color más transparente al pasar el ratón
    public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 

    public GameObject pantallaMinijuego;

    public ApareceBebidas apareceBebidas;

    public ReiniciarJuego reiniciarJuego;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;

        pantallaMinijuego = GameObject.Find("Minijuego");
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
        apareceBebidas.timearAparicion = 0;
        apareceBebidas.empiezaContar = false;
        apareceBebidas.prepBebida01.SetActive(false);
        apareceBebidas.prepBebida02.SetActive(false);
        apareceBebidas.prepBebida03.SetActive(false);
        apareceBebidas.prepBebida04.SetActive(false);
        apareceBebidas.seHaPulsadoBoton = false;
        apareceBebidas.seHaPulsadoBoton02 = false;


        reiniciarJuego.Reiniciar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
