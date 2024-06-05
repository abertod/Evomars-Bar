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

    
    
    
    //Para indicar si la botella ha sido seleccionada
    //private bool valorMantenido = false; 


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
        //Si se pulsa en el objeto y sumaTotal es menor de 5, entonces se realizan esos métodos.
        if (objetosSeleccionables.sumaTotal < 5)
        {
            //Suma en +1 la barra del Slider
            MantenerValor();
            //Suma en +1 las variables de sumaAcido y sumaTotal
            SumarValor();
        }else
        {
            Debug.Log("No se puede pulsar más en acido, suma total es 5 o mayor.");
        }
    }
    void MantenerValor()
    {
        //valorMantenido = true;
        //acidoSlider.value += acido;
        acidoSlider.value++;
        
    }

    void OnMouseEnter()
    {

        if (objetosSeleccionables.sumaTotal < 4)
        {
            
            acidoSlider.value += acido;
        }
    }

    void OnMouseExit()
    {
        if (objetosSeleccionables.sumaTotal < 5)
        {
            
            acidoSlider.value -= acido;
           
        }
    }

    
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
        //valorMantenido = false;
        acidoSlider.value = 0;
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
