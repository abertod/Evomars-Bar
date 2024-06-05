using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bebida_Sweet : MonoBehaviour
{

    public ObjetosSeleccionables objetosSeleccionables;

    //Valor de la botella
    public int sweet = 1;

    public Slider sweetSlider;
    public Image sliderFill;
    private Color colorRojo;

    //Para indicar si la botella ha sido seleccionada
    //private bool valorMantenido = false; 
    


    // Start is called before the first frame update
    void Start()
    {
        //objetosSeleccionables = GameObject.Find("Picante").GetComponent<ObjetosSeleccionables>();
        sliderFill= GameObject.Find("FillSweet").GetComponent<Image>();
        colorRojo = sliderFill.color;
    }
    void OnMouseDown()
    {
        if (objetosSeleccionables.sumaTotal < 5)
        {
            //Suma en +1 la barra del Slider
            MantenerValor();
            //Suma en +1 las variables de sumaAcido y sumaTotal
            SumarValor();
        }
        else
        {
            Debug.Log("No se puede pulsar más en sweet, suma total es 5 o mayor.");
        }
    }

    void MantenerValor()
    {
        //valorMantenido = true;
        //acidoSlider.value += acido;
        sweetSlider.value++;
    }

    void OnMouseEnter()
    {

        if (objetosSeleccionables.sumaTotal < 4)
        {
            sweetSlider.value += sweet;
        }
    }

    void OnMouseExit()
    {

        if (objetosSeleccionables.sumaTotal < 5)
        {
            sweetSlider.value -= sweet;
           
        }
    }

    
 
    void SumarValor()
    {
        //Verificar si se alcanzó el límite de pulsaciones
        if (objetosSeleccionables.sumaTotal >= 5)
        {
            Debug.Log("Se ha alcanzado el límite de pulsaciones.");
            //Salir del método sin sumar el valor
            return; 
        }

        //Sumar el valor solo si no se ha alcanzado el límite de pulsaciones
        objetosSeleccionables.sumaSweet += sweet;
        objetosSeleccionables.sumaTotal += sweet;
        Debug.Log("Valor actual de sweet: " + objetosSeleccionables.sumaSweet);

    }

    public void Reiniciar()
    {
        //Reiniciar los valores específicos de la botella picante
        sweetSlider.value = 0;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (sweetSlider.value == 0)
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
