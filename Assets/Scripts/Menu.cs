using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Menu : MonoBehaviour
{
    //Abre panel opciones
    public GameObject panelOpciones;

    //variables para usar el slider como control de volumen
    public AudioMixer voluMusic;
    //variable para activar la imagen de Estas Mute
    public float volMusica;
    public Image imageMuteMusic;
    public Image imageMuteFx;
    public Image imageMuteMaster;
    


    //public static int volumen;
    //Que se vea cual es el texto
    public GameObject numVolMus;
    public GameObject numVolMaster;
    public GameObject numVolFx;


    //public Slider slider;
    //Para llamar al slider y que se ponga en start en el numero que quiero
    public GameObject sliderMaster;
    public GameObject sliderMusic;
    public GameObject sliderFx;
    public int valor = 5;
    /*public int minValue = -80;
    public int maxValue = 20;*/


    
    
    // Start is called before the first frame update
    void Start()
    {
        //Abre panel opciones empieza desactivado
        panelOpciones = GameObject.Find("Panel_Opciones");
        panelOpciones.SetActive(false);

        //Para activar el metodo de estar silenciado al empezar
        RevisarMuteMusic();
        RevisarMuteMaster();
        RevisarMuteFx();

        //Al empezar, la música está a un volumen determinado
        sliderMaster.GetComponent<Slider>().value = valor;
        sliderMusic.GetComponent<Slider>().value = valor;
        sliderFx.GetComponent<Slider>().value = valor;

        
        //Debug.Log("Algo: "+volMusica);
        //Debug.Log("Mus: "+numVolMus);
        //Debug.Log("Fx: "+numVolFx);
                
    }

    
    // Update is called once per frame
    void Update()
    {
                
    }
    
//Método de Mute
    public void RevisarMuteMusic(){
        //Si la música está en 0, se activa una imagen
        if(volMusica == 0){
            imageMuteMusic.enabled = true;
        }else{
            imageMuteMusic.enabled = false;
        }
    }
    public void RevisarMuteMaster(){
        //Si la música está en 0, se activa una imagen
        if(volMusica == 0){
            imageMuteMaster.enabled = true;
        }else{
            imageMuteMaster.enabled = false;
        }
    }
    public void RevisarMuteFx(){
        //Si la música está en 0, se activa una imagen
        if(volMusica == 0){
            imageMuteFx.enabled = true;
        }else{
            imageMuteFx.enabled = false;
        }
    }

    public void VolumenMusica(float volume){
        //Debug.Log(volume);
        volMusica = volume;
        voluMusic.SetFloat("volMusic", volume);
        RevisarMuteMusic();
        numVolMus.GetComponent<TextMeshProUGUI>().text = volMusica.ToString();
    }
    public void VolumenMaster(float volume){
        //Debug.Log(volume);
        volMusica = volume/10;
        voluMusic.SetFloat("volMaster", volume);
        RevisarMuteMaster();
        numVolMaster.GetComponent<TextMeshProUGUI>().text = volMusica.ToString();
    }
    public void VolumenFx(float volume){
        //Debug.Log(volume);
        volMusica = volume;
        voluMusic.SetFloat("volFx", volume);
        RevisarMuteFx();
        numVolFx.GetComponent<TextMeshProUGUI>().text = volMusica.ToString();
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
