using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceMinijuego : MonoBehaviour
{

    public GameObject pantallaMinijuego;
    // Start is called before the first frame update
    void Start()
    {
        pantallaMinijuego = GameObject.Find("Minijuego");
        pantallaMinijuego.SetActive(false);

    }

    public void Minijuego(){
        pantallaMinijuego.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
