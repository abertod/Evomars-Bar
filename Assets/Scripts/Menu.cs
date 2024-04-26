using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject panelOpciones;

    

    Scrollbar barra;
    //float volMusica = 1;

    // Start is called before the first frame update
    void Start()
    {
        panelOpciones = GameObject.Find("Panel_Opciones");

        panelOpciones.SetActive(false);

        barra = GetComponent<Scrollbar>();
        barra.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AJugar(){
        SceneManager.LoadScene("2NivelUno");
        Debug.Log("A Jugar");
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
    }

    public void MostrarOpciones(){
        //AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
        panelOpciones.SetActive(true);
    }

    public void OcultarOpciones(){
        panelOpciones.SetActive(false);
    }
}
