using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Salvapantallas : MonoBehaviour
{
    //variable para texto de pulsar cualquier tecla
    public GameObject textoIni;
    //Panel opcional de escribir tu nombre
    public GameObject panel_Nombre;
    
    //variable para texto parpadeante
    public float timer;
    public static bool activated = false;


    // Start is called before the first frame update
    void Start()
    {
        //pulsar cualquier tecla
        textoIni = GameObject.Find("PulsaTeclas");
        //escribir tu nombre empieza desactivado
        panel_Nombre = GameObject.Find("Panel_Nombre");
        panel_Nombre.SetActive(false);

        

    }

    //Metodo del parpadeo
    void exit()
    {
        if (Input.touchCount > 0 && activated == false)
        {
            textoIni.SetActive(false);
            activated = true;
        }
    }

    

      // Update is called once per frame
    void Update()
    {
        //Pulsa cualquier tecla (falta que texto parpadee)
        textoIni.GetComponent<TextMeshProUGUI>().text = "Pulsa cualquier tecla";
        //activa panel del nombre
        if(Input.anyKeyDown){
            panel_Nombre.SetActive(true);
        }

        //texto parpadeo
        exit();
          timer = timer + Time.deltaTime;
          if(timer >= 0.5)
          {
                textoIni.GetComponent<TextMeshProUGUI>().enabled = true;
          }
          if(timer >= 2)
          {
                textoIni.GetComponent<TextMeshProUGUI>().enabled = false;
                timer = 0;
          }
        
    }

    public void AMenu(){
        //Carga el menu
        SceneManager.LoadScene("1Menu");
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
    }

    

}
    



