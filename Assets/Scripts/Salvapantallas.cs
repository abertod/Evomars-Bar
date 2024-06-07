using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Salvapantallas : MonoBehaviour
{
    public static Salvapantallas Instance;
    //variable para texto de pulsar cualquier tecla
    public GameObject textoIni;
    //Panel opcional de escribir tu nombre
    //public GameObject panel_Nombre;
    
    //variable para texto parpadeante
    public float timer;
    public static bool activated = false;

    //Poner nombre a tu personaje
    //public string nombre;
    //panel de confirmacion
    //public GameObject confirmaNombre;
    //public GameObject textoConfirmacion;


    // Start is called before the first frame update
    void Start()
    {
        //pulsar cualquier tecla
        textoIni = GameObject.Find("PulsaTeclas");
        /*
        //escribir tu nombre empieza desactivado
        panel_Nombre = GameObject.Find("Panel_Nombre");
        panel_Nombre.SetActive(false);

        //Panel de confirmar tu nombre
        confirmaNombre = GameObject.Find("Seguro_Nombre");
        confirmaNombre.SetActive(false);
        //Busca el objeto hijo de Seguro_Nombre
        textoConfirmacion = confirmaNombre.transform.Find("Confirma_Nombre").gameObject;
        */
        

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

/*
    //Poner Nombre al personaje que controlas para que cambie en la historia
    public void LeerNombre(string miNombre){
        nombre = miNombre;
        if (nombre == ""){
            nombre =  "Pepe";
            Debug.Log("Pepe");
        } else {
            Debug.Log(nombre);
        }

    }
    */

      // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.touchCount);
        //El texto que sale escrito al incio
        textoIni.GetComponent<TextMeshProUGUI>().text = "Pulsa cualquier tecla";
        //activa panel del nombre
        if(Input.anyKeyDown){
            //panel_Nombre.SetActive(true);
            AMenu();
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

        /*
        //Frase para confirmar tu nombre
        if(nombre == ""){
            textoConfirmacion.GetComponent<TextMeshProUGUI>().text = "¿Te llamas Pepe?";
        }else {
            textoConfirmacion.GetComponent<TextMeshProUGUI>().text = "¿Te llamas " +nombre+ "?";
            Debug.Log("¿Te llamas " +nombre+ "?");
        }
        */
        
    }
/*    public void EstasSeguro(){
        //Carga el panel de confirmar tu nombre
        confirmaNombre.SetActive(true);
    }

    public void ocultarSeguro(){
        //Oculta el panel de confirmar tu nombre
        confirmaNombre.SetActive(false);
    }
    */

    public void AMenu(){
        //Carga el menu
        SceneManager.LoadScene("1Menu");
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[0]);
    }
    public void ClickBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[1]);
    }


    

}
    



