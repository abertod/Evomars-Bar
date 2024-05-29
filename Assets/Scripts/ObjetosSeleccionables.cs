using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using UnityEngine.UIElements;

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

         // Referencia al texto en la escena donde se mostrará el nombre de la botella seleccionada
    public TMP_Text nombreBotellaText;

    // Array para almacenar los valores de las botellas seleccionadas (máximo 3)
    private int[] valoresSeleccionados = new int[3];
    private int indiceActual = 0;


    void Awake(){
        escala = 1.2f;
   
    }

    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //colorOriginal = spriteRenderer.color;

        tamañoOriginal = transform.localScale;

        nombreBotellaText = GameObject.Find("Texto").GetComponent<TMP_Text>();
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
    




    
    public void Seleccionar()
    {
        // Aquí se realizará la selección
        Debug.Log("Imagen seleccionada: " + gameObject.name);

        // Verifica si todavía hay espacio para seleccionar más botellas
        if (indiceActual < 3)
        {
            // Obtener el valor de la botella seleccionada
            int valorBotella = ObtenerValorBotella(gameObject);

            // Almacenar el valor de la botella seleccionada
            valoresSeleccionados[indiceActual] = valorBotella;
            indiceActual++;

            // Mostrar el nombre de la botella seleccionada en la escena
            MostrarNombreBotella(gameObject.name);
        }
        else
        {
            Debug.Log("Ya se han seleccionado 3 botellas.");
        }
    }

    // Método para obtener el valor de la botella seleccionada
    int ObtenerValorBotella(GameObject botella)
    {
        if (botella.CompareTag("Bebida_Acido"))
        {
            return botella.GetComponent<Bebida_Acido>().acido;
        }
        else if (botella.CompareTag("Bebida_Dulce"))
        {
            return botella.GetComponent<Bebida_Dulce>().dulce;
        }
        else if (botella.CompareTag("Bebida_Picante"))
        {
            return botella.GetComponent<Bebida_Picante>().picante;
        }
        else
        {
            // En caso de que la etiqueta no esté definida, devuelve 0
            Debug.LogWarning("La etiqueta de la botella no está definida correctamente.");
            return 0;
        }
    }


    // Método para mostrar el nombre de la botella seleccionada en la escena
    private void MostrarNombreBotella(string nombre)
    {
        nombreBotellaText.text = "Botella seleccionada: " + nombre;
    }

    
    // Update is called once per frame
    void Update()
    {

    }




}
