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

    // Variables para el registro de pulsaciones
    public static List<string> pulsacionesRecientes = new List<string>();
    public static int contadorPulsaciones = 0;
    public static bool permitirNuevasPulsaciones = true;

    // Array para los textos que mostrarán los nombres de las botellas
    public TMP_Text[] textosPulsaciones; 


    public static int sumaPicante = 0;
    public static int sumaDulce = 0;
    public static int sumaAcido = 0;

    public static int sumaTotal;

    private int cuadradosRellenados = 0;


    void Awake(){
        escala = 1.2f;
   
    }

    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //colorOriginal = spriteRenderer.color;

        tamañoOriginal = transform.localScale;

        nombreBotellaText = GameObject.Find("Texto").GetComponent<TMP_Text>();

        textosPulsaciones = new TMP_Text[5];
        for (int i = 0; i < 5; i++)
        {
            textosPulsaciones[i] = GameObject.Find("Texto" + (i + 1)).GetComponent<TMP_Text>();
        }

       
    }

    void OnMouseDown()
    {
       if (permitirNuevasPulsaciones && contadorPulsaciones < 5)
        {
            Seleccionar();
        }

    }

    void OnMouseEnter()
    {
        // Cuando el ratón entra en el objeto
        //spriteRenderer.color = colorAlPasarElRaton;
        if (permitirNuevasPulsaciones && contadorPulsaciones < 5)
        {
            transform.localScale = tamañoOriginal * escala;
        }
        
    }

    void OnMouseExit()
    {
        // Cuando el ratón sale del objeto
        //spriteRenderer.color = colorOriginal;
        transform.localScale = tamañoOriginal;
        
    }

 
    
    
    public void Seleccionar()
    {
        
        if (permitirNuevasPulsaciones && contadorPulsaciones < 5) // Verificar si aún se pueden hacer nuevas pulsaciones y si no se ha alcanzado el límite de 5
    {
        string nombreBebida = gameObject.name;
        Debug.Log("Imagen seleccionada: " + nombreBebida);
        pulsacionesRecientes.Insert(0, nombreBebida);
        contadorPulsaciones++;
        ActualizarTextos();
        
    }
       
    }

    void ActualizarSumaTotal()
    {
        sumaTotal = sumaPicante + sumaDulce + sumaAcido;

        if (sumaTotal >= 5)
    {
        permitirNuevasPulsaciones = false;
        Debug.Log("Se ha alcanzado el límite de suma total.");
    }
    }

    void ActualizarTextos()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i < contadorPulsaciones)
            {
                textosPulsaciones[i].text = pulsacionesRecientes[i];
            }
            else
            {
                textosPulsaciones[i].text = "";
            }
        }

        if (contadorPulsaciones >= 5)
        {
            permitirNuevasPulsaciones = false;
            Debug.Log("Ya no se pueden registrar más pulsaciones.");
        }

       // Calcula la suma total
    ActualizarSumaTotal(); 

    // Muestra las sumas individuales y la suma total
    Debug.Log("Suma picante: " + sumaPicante);
    Debug.Log("Suma dulce: " + sumaDulce);
    Debug.Log("Suma ácido: " + sumaAcido);
    Debug.Log("Suma total: " + sumaTotal);

    
    
    }

    public void Reiniciar()
    {
        permitirNuevasPulsaciones = true;
        pulsacionesRecientes.Clear();
        contadorPulsaciones = 0;
        sumaPicante = 0;
        sumaDulce = 0;
        sumaAcido = 0;
        sumaTotal = 0;
    }

    
    // Update is called once per frame
    void Update()
    {

    }




}