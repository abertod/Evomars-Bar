using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    public static Luces lucesInstance;
    public GameObject luces;
    //public GameObject minijuego;
    //public bool activado = false;

    

    // Start is called before the first frame update
    void Start()
    {
        luces = GameObject.Find("luces");
    }

    // Update is called once per frame
    void Update()
    {
        /*if(ApareceMinijuego.apareceMinijuego.activado==true){
            luces.SetActive(false);
        }else{
            luces.SetActive(true);
        }*/

        
    }
}
