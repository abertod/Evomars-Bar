using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    public static Luces lucesInstance;
    public GameObject luces;
    public GameObject minijuego;

    //public GameObject minijuego2;
    //public bool activado = false;

    

    // Start is called before the first frame update
    void Start()
    {
        luces = GameObject.Find("luces");
        minijuego = GameObject.Find("Minijuego");
        //minijuego2 = GameObject.Find("Minijuego_2");
    }

    public void DesactivarLuces()
    {
        luces.SetActive(false);
        
    }

    public void ActivarLuces()
    {
        luces.SetActive(true);
    }

    /*public void DesactivarLuces02()
    {
        luces.SetActive(false);
        
    }

    public void ActivarLuces02()
    {
        luces.SetActive(true);
    }*/

    // Update is called once per frame
    void Update()
    {
        if(minijuego.activeSelf){
            DesactivarLuces();
        }else{
            ActivarLuces();
        }

        /*if(minijuego2.activeSelf){
            DesactivarLuces02();
        }else{
            ActivarLuces02();
        }*/

        
    }
}
