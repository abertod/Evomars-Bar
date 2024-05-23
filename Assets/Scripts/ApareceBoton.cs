using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApareceBoton : MonoBehaviour
{
    public GameObject btn;
    public float timear = 0;
    public bool activated = false;


    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("Botones");
        btn.SetActive(false);

        //Añade un listener al botón para que llame a la función OnButtonClick cuando se pulse
        //btn.GetComponent<Button>().onClick.AddListener(OnButtonClick);
        
    }

    public void DesactivarBtn()
    {
        // Desactiva el botón
        btn.SetActive(false);
        activated = true;
    }


    // Update is called once per frame
    void Update()
    {
  
        timear = timear + Time.deltaTime;
 
        // Activa el botón después de 2 segundos
        if (timear > 2 && !btn.activeSelf && !activated)
        {
            btn.SetActive(true);
        }

        // Para mostrar el número de toques en pantalla
        //Debug.Log("Toque " + Input.touchCount);
          

    }


}
