using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bebida_Acido : MonoBehaviour
{
    public ObjetosSeleccionables objetosSeleccionables;

    //Valor de la botella
    public int acido = 1;

    //Array a los cuadrados de UI
    public SpriteRenderer[] acidoCuadrados;

    //Sprites para cuadrado lleno y vacío
    public Sprite cuadradoLleno;
    public Sprite cuadradoVacio;
    
    //Para indicar si la botella ha sido seleccionada
    private bool valorMantenido = false; 
    
    private int cuadradosRellenados  = 0;
    // Start is called before the first frame update
    void Start()
    {
        objetosSeleccionables = GameObject.Find("Picante").GetComponent<ObjetosSeleccionables>();
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
        RellenarCuadrados(acidoCuadrados, cuadradosRellenados);
    }

    void MostrarSiguienteCuadradoLleno()
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
        cuadradosRellenados = 0;
        valorMantenido = false;
        LimpiarPrevisualizacion();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
