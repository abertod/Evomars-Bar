using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ObjetosSeleccionables : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    //private Color colorOriginal;

    // Color más transparente al pasar el ratón
    //public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 
    
    public float escala;
    private Vector3 tamañoOriginal;

    public float timer;
    public static bool activated = false;

    //public Shader shader = new Shader("");

    void Awake(){
        escala = 1.2f;
    }

    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //colorOriginal = spriteRenderer.color;

        tamañoOriginal = transform.localScale;
    }

    void OnMouseDown()
    {
        // Esta función se activará cuando el jugador haga clic en la imagen
        Seleccionar();
    }

    void OnMouseEnter()
    {
        // Cuando el ratón entra en el objeto
        //spriteRenderer.color = colorAlPasarElRaton;
        transform.localScale = tamañoOriginal*escala;
    }

    void OnMouseExit()
    {
        // Cuando el ratón sale del objeto
        //spriteRenderer.color = colorOriginal;
        transform.localScale = tamañoOriginal;
    }

    /*
    //Metodo del parpadeo
    void exit()
    {
        if (Input.touchCount > 0 && activated == false)
        {
            //spriteRenderer.SetActive(false);
            spriteRenderer.flipX = false;
            //spriteRenderer.color = Random.ColorHSV();
            activated = true;
        }
    }*/
    
    void Seleccionar()
    {
        // Aquí se realizará la selección
        Debug.Log("Imagen seleccionada: " + gameObject.name);
    }

    
    // Update is called once per frame
    void Update()
    {
        /*
        //Es una prueba. Es para intentar que parpadeen con un brillo para que se sepa que son objetos interactuables
        exit();
          timer = timer + Time.deltaTime;
          if(timer >= 0.5)
          {
                spriteRenderer.flipX = true;
                //spriteRenderer.color = colorOriginal;
          }
          if(timer >= 2)
          {
                spriteRenderer.flipX = false;
                //spriteRenderer.color = Random.ColorHSV();
                timer = 0;
          }
          */
    }




}
