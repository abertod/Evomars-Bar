using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
    }

    void exit()
    {
        Debug.Log(Input.touchCount);
        /*if (btn == true && Input.touchCount == 1 && activated = false )
        {
            Debug.Log("click");
            btn.SetActive(false);
            activated = true;
        } */
        if (Input.touchCount == 1 )
        {
            Debug.Log("click");
            btn.SetActive(false);
            activated = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
              
          timear = timear + Time.deltaTime;
          if(timear > 2)
          {
                btn.SetActive(true);
                //textoIni.GetComponent<TextMeshProUGUI>().enabled = true;
          }
          exit();
          /*if(timer >= 2)
          {
                //textoIni.GetComponent<TextMeshProUGUI>().enabled = false;
                timer = 0;
          }*/
    }
}
