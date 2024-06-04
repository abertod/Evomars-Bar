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


    public GameObject prepBebida05;
    public GameObject prepBebida06;
    public GameObject prepBebida07;

    
    //public GameObject botonPrep;
    public float timearAparicion = 0;
    //public bool activated = false;

    //para controlar si se debe empezar a contar el tiempo
    public bool empiezaContar = false; 

    public bool seHaPulsadoBoton = false;
    public bool seHaPulsadoBoton02 = false;

    public bool empiezaContar02 = false; 

    // Start is called before the first frame update
    void Start()
    {
        //prepBebidaCanvas = GameObject.Find("Imagenes_Prep");
        prepBebida01 = GameObject.Find("preparacion_cocteles_01");
        prepBebida02 = GameObject.Find("preparacion_cocteles_02");
        prepBebida03 = GameObject.Find("preparacion_cocteles_03");
        prepBebida04 = GameObject.Find("preparacion_cocteles_04");


        prepBebida05 = GameObject.Find("preparacion_cocteles_chica_01");
        prepBebida06 = GameObject.Find("preparacion_cocteles_chica_02");
        prepBebida07 = GameObject.Find("preparacion_cocteles_chica_03");

        
        //botonPrep = GameObject.Find("BotonPrep");

        //prepBebidaCanvas.SetActive(false);
        prepBebida01.SetActive(false);
        prepBebida02.SetActive(false);
        prepBebida03.SetActive(false);
        prepBebida04.SetActive(false);


        prepBebida05.SetActive(false);
        prepBebida06.SetActive(false);
        prepBebida07.SetActive(false);

        //botonPrep.SetActive(false);
        //Debug.Log(prepBebida01 + "está: " + activated);
    }

    public void AparecenBebidas(){

        // Cuando se llama a este método, se empieza a contar el tiempo
        empiezaContar = true; 

    }

    public void AparecenImagenesPreparación()
    {
        // Si empiezaContar es verdadero, comienza a contar el tiempo
        if (empiezaContar && seHaPulsadoBoton)
        {
            timearAparicion = timearAparicion + Time.deltaTime;

            //prepBebidaCanvas.SetActive(true);

            // Activa las bebidas después de ciertos intervalos de tiempo
            if (timearAparicion > 0.5 && !prepBebida01.activeSelf)
            {
                prepBebida01.SetActive(true);
                AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[2]);
                //Debug.Log("boton está: " + prepBebida01);
            }
            else if (timearAparicion > 1.2 && !prepBebida02.activeSelf)
            {
                prepBebida02.SetActive(true);
                AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[3]);
                //Debug.Log("boton está: " + prepBebida02);
            }
            else if (timearAparicion > 2 && !prepBebida03.activeSelf)
            {
                prepBebida03.SetActive(true);
                AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[4]);
                //Debug.Log("boton está: " + prepBebida03);
            }
            else if (timearAparicion > 3 && !prepBebida04.activeSelf)
            {
                prepBebida04.SetActive(true);
                //Debug.Log("boton está: " + prepBebida03);
            }
        }
    }

    public void Aparecen02Bebidas(){

        // Cuando se llama a este método, se empieza a contar el tiempo
        empiezaContar02 = true; 

    }

    public void Aparecen02ImagenesPreparación()
    {
        // Si empiezaContar es verdadero, comienza a contar el tiempo
        if (empiezaContar && seHaPulsadoBoton02)
        {
            timearAparicion = timearAparicion + Time.deltaTime;

            //prepBebidaCanvas.SetActive(true);

            // Activa las bebidas después de ciertos intervalos de tiempo
            if (timearAparicion > 0.5 && !prepBebida05.activeSelf)
            {
                prepBebida05.SetActive(true);
                AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[2]);
                //Debug.Log("boton está: " + prepBebida01);
            }
            else if (timearAparicion > 1.2 && !prepBebida06.activeSelf)
            {
                prepBebida06.SetActive(true);
                AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[3]);
                //Debug.Log("boton está: " + prepBebida02);
            }
            else if (timearAparicion > 2 && !prepBebida07.activeSelf)
            {
                prepBebida07.SetActive(true);
                AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[4]);
                //Debug.Log("boton está: " + prepBebida03);
            }
            else if (timearAparicion > 3 && !prepBebida04.activeSelf)
            {
                prepBebida04.SetActive(true);
                //Debug.Log("boton está: " + prepBebida03);
            }
        }
    }


    public void DetectarPulsacionBoton()
    {
        
        seHaPulsadoBoton = true;
    }

    public void DetectarPulsacionBoton02()
    {
        
        seHaPulsadoBoton02 = true;
    }

    // Update is called once per frame
    public void Update()
    {

        AparecenImagenesPreparación();
        Aparecen02ImagenesPreparación();
        
    }
}

