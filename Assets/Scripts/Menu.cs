using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    //Abre panel opciones
    public GameObject panelOpciones;

    
    //public AudioMixer voluMusic;
    //variables para usar el scrollbar como control de volumen
    public Scrollbar barra;
    public float volMusica;
    public Image imageMute;

    // Start is called before the first frame update
    void Start()
    {
        //Abre panel opciones empieza desactivado
        panelOpciones = GameObject.Find("Panel_Opciones");
        panelOpciones.SetActive(false);

        //Contro lde volumen
        barra.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = barra.value;
        RevisarSiEstoyMute();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiaAudio(float valor){
        //Control de volumen
        volMusica = valor;
        PlayerPrefs.SetFloat("volumenAudio", volMusica);
        AudioListener.volume = barra.value;
        RevisarSiEstoyMute();
    }

    public void RevisarSiEstoyMute(){
        //Si la música está en 0, se activa una imagen
        if(volMusica == 0){
            imageMute.enabled = true;
        }else{
            imageMute.enabled = false;
        }
    }

    public void CambiaVolumen(float volume){
        //Debug.Log(volume);
        //voluMusic.SetFloat("volMusic", volume);

        //barra.value = audioMusic.volume; 
    }
  
    public void AJugar(){
        //Empieza el juego
        SceneManager.LoadScene("2NivelUno");
        Debug.Log("A Jugar");
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
    }

    public void MostrarOpciones(){
        //Activa panel opciones
        //AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
        panelOpciones.SetActive(true);
    }

    public void OcultarOpciones(){
        //Oculta panel opciones
        panelOpciones.SetActive(false);
    }
}
