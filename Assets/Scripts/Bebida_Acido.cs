using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bebida_Acido : MonoBehaviour
{
    public ObjetosSeleccionables objetosSeleccionables;

    //Valor de la botella
    public int acido = 1;

    public Slider acidoSlider;
    public Image sliderFill;
    private Color colorRojo;

    //Array a los cuadrados de UI
    //public SpriteRenderer[] acidoCuadrados;

    //Sprites para cuadrado lleno y vacío
    //public Sprite cuadradoLleno;
    //public Sprite cuadradoVacio;
    
    //Para indicar si la botella ha sido seleccionada
    private bool valorMantenido = false; 

    
    
    //private int cuadradosRellenados  = 0;

    // Start is called before the first frame update
    void Start()
    {
        //objetosSeleccionables = GameObject.Find("Picante").GetComponent<ObjetosSeleccionables>();
        //acidoSlider = Slider.Find
        sliderFill= GameObject.Find("FillAcido").GetComponent<Image>();
        colorRojo = sliderFill.color;

    }

    void OnMouseDown()
    {
        if (objetosSeleccionables.sumaTotal < 5)
        {
            MantenerValor();
            SumarValor();
        }
    }
    void MantenerValor()
    {
        valorMantenido = true;
        //cuadradosRellenados++;
        //acidoSlider.value += acido;
        acidoSlider.value++;
        MostrarValores();
    }

    void OnMouseEnter()
    {

        if (objetosSeleccionables.sumaTotal < 5)
        {
            if (!valorMantenido)
            {
                
                MostrarValores();
            }
            //MostrarSiguienteCuadradoLleno();
            //acidoSlider.value += acido;
        }
    }

    void OnMouseExit()
    {
        if (objetosSeleccionables.sumaTotal < 5)
        {
            if (valorMantenido)
            {
               
                MostrarValores(); // Volver al estado original cuando el ratón sale de la botella
            }
            /*else
            {
                //LimpiarPrevisualizacion(); // Limpiar la previsualización
                //acidoSlider.value -= acido;
            }*/
        }
    }

    void MostrarValores()
    {
        
        //RellenarCuadrados(acidoCuadrados, cuadradosRellenados);
    }

    /*void MostrarSiguienteCuadradoLleno()
    {
        if (cuadradosRellenados < acidoCuadrados.Length && objetosSeleccionables.sumaTotal < 5 )
        {
            for (int i = 0; i <= cuadradosRellenados; i++)
            {
                acidoCuadrados[i].sprite = cuadradoLleno;
            }
        }
    }

    void LimpiarPrevisualizacion()
    {
        if (cuadradosRellenados < acidoCuadrados.Length && objetosSeleccionables.sumaTotal < 5)
        {
            acidoCuadrados[cuadradosRellenados].sprite = cuadradoVacio;
        }
    }

    void RellenarCuadrados(SpriteRenderer[] cuadrados, int cantidad)
    {
        
        for (int i = 0; i < cuadrados.Length; i++)
        {
            if (i < cantidad && objetosSeleccionables.sumaTotal < 5)
            {
                cuadrados[i].sprite = cuadradoLleno;
            }
            else
            {
                cuadrados[i].sprite = cuadradoVacio;
            }
        }
    }*/

    void SumarValor()
    {
        //Verificar si se alcanzó el límite de pulsaciones
        if (objetosSeleccionables.sumaTotal >= 5)
        {
            Debug.Log("Se ha alcanzado el límite de pulsaciones.");
            return; // Salir del método sin sumar el valor
        }

        objetosSeleccionables.sumaAcido += acido;
        objetosSeleccionables.sumaTotal += acido;
        Debug.Log("Valor actual de ácido: " + objetosSeleccionables.sumaAcido);
    }


    public void Reiniciar()
    {
        //Reiniciar los valores específicos de la botella picante
        //cuadradosRellenados = 0;
        valorMantenido = false;
        acidoSlider.value = 0;
        //LimpiarPrevisualizacion();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (acidoSlider.value == 0)
        {
            //Cambia el color de la barra a transparente
            sliderFill.color = Color.clear;
        }
        else
        {
            //Deja el color a su original
            sliderFill.color = colorRojo;
        }

        
    }

    
}
