using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApareceBoton : MonoBehaviour
{

    public static ApareceBoton apareceBoton;
    public GameObject btn;
    public float timear = 0;
    public bool activated = false;

    public GameObject KoemiInicio;
    public GameObject KaneInicio;

    //public float timeT;
    public bool contarT;

    //public GameObject AvanzarPanel;


    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("Botones");
        btn.SetActive(false);
        btn.SetActive(true);
        activated = true;
        //Debug.Log("boton esta: " + activated);
        //Añade un listener al botón para que llame a la función OnButtonClick cuando se pulse
        //btn.GetComponent<Button>().onClick.AddListener(OnButtonClick);


        KoemiInicio = GameObject.Find("Character - [Koemi]");
        KaneInicio = GameObject.Find("Character - [Kane]");
        KoemiInicio.SetActive(true);
        KaneInicio.SetActive(true);
    }

    public void DesactivarBtn()
    {
        // Desactiva el botón
        btn.SetActive(false);
        activated = true;
        //Debug.Log("boton esta: " + activated);

        contarT = true;
        
    }

    public void DesactivarFrameInicial(){
        KoemiInicio.SetActive(false);
        KaneInicio.SetActive(false);
    }

    /*public void CuentaTimeT(){
        timeT = timeT + Time.deltaTime;
    }*/


    // Update is called once per frame
    void Update()
    {
        /*
        timear += Time.deltaTime;
 
        // Activa el botón después de 2 segundos
        if (timear > 2 && !btn.activeSelf && !activated)
        {
            btn.SetActive(true);
            activated = true;
            //Debug.Log("boton esta: " + activated);
            
        }

        

        /*if(contarT ){
            CuentaTimeT();
        }*/

        

        // Para mostrar el número de toques en pantalla
        //Debug.Log("Toque " + Input.touchCount);
        

    }


}
