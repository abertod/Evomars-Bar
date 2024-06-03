using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceMinijuego : MonoBehaviour
{
    public static ApareceMinijuego apareceMinijuego;
    public bool activado = false;
    //public static ApareceMinijuego Instance;

    public GameObject pantallaMinijuego;
    //public GameObject canvasBotonPreparar;
    // Start is called before the first frame update
    void Start()
    {
        pantallaMinijuego = GameObject.Find("Minijuego");
        //canvasBotonPreparar = GameObject.Find("Boton_Preparar");
        pantallaMinijuego.SetActive(false);
        //canvasBotonPreparar.SetActive(false);

    }

    public void Minijuego(){
        pantallaMinijuego.SetActive(true);
        //canvasBotonPreparar.SetActive(true);
        activado = true;
    }

    public void DesactivarMinijuego(){
        pantallaMinijuego.SetActive(false);
        activado = false;
        //canvasBotonPreparar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
