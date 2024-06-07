using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Nombre : MonoBehaviour
{
    public static Nombre nombreInstance;
    public GameObject panel_Nombre;

    public string nombre;
    //panel de confirmacion
    public GameObject confirmaNombre;
    public GameObject textoConfirmacion;

    // Start is called before the first frame update
    void Start()
    {
        //escribir tu nombre empieza desactivado
        panel_Nombre = GameObject.Find("Panel_Nombre");
        panel_Nombre.SetActive(false);

        //Panel de confirmar tu nombre
        confirmaNombre = GameObject.Find("Seguro_Nombre");
        confirmaNombre.SetActive(false);
        //Busca el objeto hijo de Seguro_Nombre
        textoConfirmacion = confirmaNombre.transform.Find("Confirma_Nombre").gameObject;
    }

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

    // Update is called once per frame
    void Update()
    {
        //Frase para confirmar tu nombre
        if(nombre == ""){
            textoConfirmacion.GetComponent<TextMeshProUGUI>().text = "¿Te llamas Pepe?";
        }else {
            textoConfirmacion.GetComponent<TextMeshProUGUI>().text = "¿Te llamas " +nombre+ "?";
            Debug.Log("¿Te llamas " +nombre+ "?");
        }
    }

    public void EstasSeguro(){
        //Carga el panel de confirmar tu nombre
        confirmaNombre.SetActive(true);
    }

    public void ocultarSeguro(){
        //Oculta el panel de confirmar tu nombre
        confirmaNombre.SetActive(false);
    }
    public void AJugar(){
        //Empieza el juego
        SceneManager.LoadScene(2);
        Debug.Log("A Jugar");
        
        
    }
}
