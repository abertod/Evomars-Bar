using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida_Dulce02 : MonoBehaviour
{
    public ObjetosSeleccionables objetosSeleccionables;

    //Valor de la botella
    public int dulce = 1;

    //Array a los cuadrados de UI
    public SpriteRenderer[] dulceCuadrados;

    //Sprites para cuadrado lleno y vacío
    public Sprite cuadradoLleno;
    public Sprite cuadradoVacio;

    //Para indicar si la botella ha sido seleccionada
    private bool valorMantenido = false; 
    private int cuadradosRellenados  = 0;

    // Start is called before the first frame update
    void Start()
    {
        //objetosSeleccionables = GameObject.Find("Picante").GetComponent<ObjetosSeleccionables>();
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
        cuadradosRellenados++;
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
            MostrarSiguienteCuadradoLleno();
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
            else
            {
                LimpiarPrevisualizacion(); // Limpiar la previsualización
            }
        }
    }

    void MostrarValores()
    {
        RellenarCuadrados(dulceCuadrados, cuadradosRellenados);
    }

    void MostrarSiguienteCuadradoLleno()
    {
        if (cuadradosRellenados < dulceCuadrados.Length && objetosSeleccionables.sumaTotal < 5 )
        {
            for (int i = 0; i <= cuadradosRellenados; i++)
            {
                dulceCuadrados[i].sprite = cuadradoLleno;
            }
        }
    }

    void LimpiarPrevisualizacion()
    {
        if (cuadradosRellenados < dulceCuadrados.Length && objetosSeleccionables.sumaTotal < 5)
        {
            dulceCuadrados[cuadradosRellenados].sprite = cuadradoVacio;
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
    }
    
    void SumarValor()
    {
        // Verificar si se alcanzó el límite de pulsaciones
        if (objetosSeleccionables.sumaTotal >= 5)
        {
            Debug.Log("Se ha alcanzado el límite de pulsaciones.");
            //Salir del método sin sumar el valor
            return; 
        }

        objetosSeleccionables.sumaDulce += dulce;
        objetosSeleccionables.sumaTotal += dulce;
        Debug.Log("Valor actual de dulce: " + objetosSeleccionables.sumaDulce);
    }

    public void Reiniciar()
    {
        //Reiniciar los valores específicos de la botella picante
        cuadradosRellenados = 0;
        valorMantenido = false;
        LimpiarPrevisualizacion();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
