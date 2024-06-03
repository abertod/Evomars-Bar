using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceBebidasKoemi : MonoBehaviour
{
    //public GameObject prepBebidaCanvas;
    
    public GameObject prepBebida08;

    public GameObject prepBebida05;
    public GameObject prepBebida06;
    public GameObject prepBebida07;
    //public GameObject botonPrep;
    public float timearAparicion = 0;
    //public bool activated = false;

    //para controlar si se debe empezar a contar el tiempo
    public bool empiezaContar = false; 

    // Start is called before the first frame update
    void Start()
    {
        //prepBebidaCanvas = GameObject.Find("Imagenes_Prep");
       
        prepBebida08 = GameObject.Find("preparacion_cocteles_08");

        prepBebida05 = GameObject.Find("preparacion_cocteles_chica_01");
        prepBebida06 = GameObject.Find("preparacion_cocteles_chica_02");
        prepBebida07 = GameObject.Find("preparacion_cocteles_chica_03");
        //botonPrep = GameObject.Find("BotonPrep");

        //prepBebidaCanvas.SetActive(false);
       
        prepBebida08.SetActive(false);

        prepBebida05.SetActive(false);
        prepBebida06.SetActive(false);
        prepBebida07.SetActive(false);
        //botonPrep.SetActive(false);
        //Debug.Log(prepBebida01 + "está: " + activated);
    }

    /*public void AparecenBebidas(){

        // Cuando se llama a este método, se empieza a contar el tiempo
        empiezaContar = true; 

    }

    public void AparecenImagenesPreparación()
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

    // Update is called once per frame
    public void Update()
    {

        AparecenImagenesPreparación();
        
    }*/
}

