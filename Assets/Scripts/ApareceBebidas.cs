using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceBebidas : MonoBehaviour
{
    //public GameObject prepBebidaCanvas;
    public GameObject prepBebida01;
    public GameObject prepBebida02;
    public GameObject prepBebida03;
    public GameObject prepBebida04;
    //public GameObject botonPrep;
    public float timearAparicion = 0;
    public bool activated = false;

    //para controlar si se debe empezar a contar el tiempo
    public bool empiezaContar = false; 

    // Start is called before the first frame update
    void Start()
    {
        //prepBebidaCanvas = GameObject.Find("Imagenes_Prep");
        prepBebida01 = GameObject.Find("preparacion_cocteles_01");
        prepBebida02 = GameObject.Find("preparacion_cocteles_02");
        prepBebida03 = GameObject.Find("preparacion_cocteles_03");
        prepBebida04 = GameObject.Find("preparacion_cocteles_04");
        //botonPrep = GameObject.Find("BotonPrep");

        //prepBebidaCanvas.SetActive(false);
        prepBebida01.SetActive(false);
        prepBebida02.SetActive(false);
        prepBebida03.SetActive(false);
        prepBebida04.SetActive(false);
        //botonPrep.SetActive(false);
        //Debug.Log(prepBebida01 + "está: " + activated);
    }

    public void AparecenBebidas(){

        // Cuando se llama a este método, se empieza a contar el tiempo
        empiezaContar = true; 

    }

    // Update is called once per frame
    void Update()
    {
        
        // Si empiezaContar es verdadero, comienza a contar el tiempo
        if (empiezaContar)
        {
            timearAparicion = timearAparicion + Time.deltaTime;

            //prepBebidaCanvas.SetActive(true);

            // Activa las bebidas después de ciertos intervalos de tiempo
            if (timearAparicion > 0.5 && !prepBebida01.activeSelf)
            {
                prepBebida01.SetActive(true);
                //Debug.Log("boton está: " + prepBebida01);
            }
            else if (timearAparicion > 1.2 && !prepBebida02.activeSelf)
            {
                prepBebida02.SetActive(true);
                //Debug.Log("boton está: " + prepBebida02);
            }
            else if (timearAparicion > 2 && !prepBebida03.activeSelf)
            {
                prepBebida03.SetActive(true);
                //Debug.Log("boton está: " + prepBebida03);
            }
            else if (timearAparicion > 3 && !prepBebida04.activeSelf)
            {
                prepBebida04.SetActive(true);
                //Debug.Log("boton está: " + prepBebida03);
            }
        }
        
    }
}
