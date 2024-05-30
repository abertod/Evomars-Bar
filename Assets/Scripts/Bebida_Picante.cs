using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bebida_Picante : MonoBehaviour
{

    // Valores de la botella
    public int picante = 1;

    // Referencias a los cuadrados de UI
    public SpriteRenderer[] picanteCuadrados;

    // Sprites para cuadrado lleno y vacío
    public Sprite cuadradoLleno;
    public Sprite cuadradoVacio;

    private bool valorMantenido = false; // Flag para indicar si la botella ha sido seleccionada
    private int cuadradosRellenados  = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        if (ObjetosSeleccionables.sumaTotal < 5)
    {
        MantenerValor();
        SumarValor();
    }
    else
    {
        Debug.Log("No se puede pulsar más, suma total es 5 o mayor.");
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

        if (ObjetosSeleccionables.sumaTotal < 5)
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

        if (ObjetosSeleccionables.sumaTotal < 5)
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
        RellenarCuadrados(picanteCuadrados, cuadradosRellenados);
    }
    void MostrarSiguienteCuadradoLleno()
{
    
    if (cuadradosRellenados < picanteCuadrados.Length && ObjetosSeleccionables.sumaTotal < 5 && !valorMantenido)
    {
        for (int i = 0; i <= cuadradosRellenados; i++)
        {
            picanteCuadrados[i].sprite = cuadradoLleno;
        }
    }
}


    void LimpiarPrevisualizacion()
    {
        if (cuadradosRellenados < picanteCuadrados.Length && ObjetosSeleccionables.sumaTotal < 5)
        {
            picanteCuadrados[cuadradosRellenados].sprite = cuadradoVacio;
        }
    }

    void RellenarCuadrados(SpriteRenderer[] cuadrados, int cantidad)
    {
    
        for (int i = 0; i < cuadrados.Length; i++)
        {
            if (i < cantidad && ObjetosSeleccionables.sumaTotal < 5)
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
    if (ObjetosSeleccionables.sumaTotal >= 5)
    {
        Debug.Log("Se ha alcanzado el límite de pulsaciones.");
        return; // Salir del método sin sumar el valor
    }

    // Sumar el valor solo si no se ha alcanzado el límite de pulsaciones
    ObjetosSeleccionables.sumaPicante += picante;
    ObjetosSeleccionables.sumaTotal += picante;
    Debug.Log("Valor actual de picante: " + ObjetosSeleccionables.sumaPicante);

    }

    public void Reiniciar()
    {
        // Reiniciar los valores específicos de la botella picante
        cuadradosRellenados = 0;
        valorMantenido = false;
        LimpiarPrevisualizacion();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
