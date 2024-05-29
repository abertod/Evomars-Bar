using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bebida_Picante : MonoBehaviour
{

    // Valores de la botella
    public int picante = 3;

    // Referencias a los cuadrados de UI
    public SpriteRenderer[] picanteCuadrados;

    // Sprites para cuadrado lleno y vacío
    public Sprite cuadradoLleno;
    public Sprite cuadradoVacio;

// Referencia al script de selección
    private ObjetosSeleccionables objetosSeleccionables;



    // Start is called before the first frame update
    void Start()
    {
        objetosSeleccionables = GameObject.Find("Minijuego").GetComponent<ObjetosSeleccionables>();
    }

    void OnMouseEnter()
    {

        MostrarValores(true);
    }

    void OnMouseExit()
    {

        MostrarValores(false);
    }

   /* void OnMouseDown()
    {
        objetosSeleccionables.SeleccionarBotella(picante, "Bebida Picante");
    }*/

    void MostrarValores(bool mostrar)
    {
        // Rellenar o vaciar los cuadrados de acuerdo al valor
        RellenarCuadrados(picanteCuadrados, picante, mostrar);
    }

    void RellenarCuadrados(SpriteRenderer[] cuadrados, int valor, bool mostrar)
    {
        for (int i = 0; i < cuadrados.Length; i++)
        {
            if (mostrar && i < valor)
            {
                cuadrados[i].sprite = cuadradoLleno;
            }
            else
            {
                cuadrados[i].sprite = cuadradoVacio;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
