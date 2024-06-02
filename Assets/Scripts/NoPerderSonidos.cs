using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoPerderSonidos : MonoBehaviour
{
    bool opcionOn = false;
    //public GameObject panelOpciones;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AJugar(){
        //Empieza el juego
        SceneManager.LoadScene(2);
        Debug.Log("A Jugar");
        
        
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[0]);
    }
    public void ClickBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[1]);
    }
    public void MostrarOpciones(){
        //Activa panel opciones
        //AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
        Menu.Instance.panelOpciones.SetActive(true);
        opcionOn=true;
        Debug.Log("panel: " + opcionOn);
    }

    public void OcultarOpciones(){
        //Oculta panel opciones
        Menu.Instance.panelOpciones.SetActive(false);
        opcionOn=false;
        Debug.Log("panel: " + opcionOn);
    }

    public void ExitGame(){
        Debug.Log("exit");
        Application.Quit();
    }

}
