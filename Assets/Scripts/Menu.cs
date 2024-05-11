using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using Unity.Mathematics;

public class Menu : MonoBehaviour
{
    public static Menu Instance;
    //Abre panel opciones
    public GameObject panelOpciones;

    //variables para usar el slider como control de volumen
    public AudioMixer voluMusic;
    //variable para el nivel del volumen
    public GameObject volumenMaster;
    public GameObject volumenMusic;
    public GameObject volumenFx;
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


    //El objeto que está por encima del Slider de Velocidad de texto. Primero llama y encuentra el objeto de Velocidad Texto y luego, 
    //con otra variable y Find, se puede buscar al hijo, SliderVel
    public GameObject velTexto;
    public GameObject sliderVelTexto;
    //Variable para cambiar texto a Normal, lento o rapido de velocidad
    public GameObject textoVelociad;


    bool opcionOn = false;

    
    void Awake(){
        if(Instance != null && Instance != this){
            Destroy(this.gameObject);
        }else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Abre panel opciones empieza desactivado
        panelOpciones = GameObject.Find("Panel_Opciones");
        panelOpciones.SetActive(false);

        // Busca los GameObjects
        volumenMaster = panelOpciones.transform.Find("VolumenMaster").gameObject;
        volumenMusic = panelOpciones.transform.Find("VolumenMusic").gameObject;
        volumenFx = panelOpciones.transform.Find("VolumenFx").gameObject;

        sliderMaster = volumenMaster.transform.Find("SliderMaster").gameObject;
        sliderMusic = volumenMusic.transform.Find("SliderMusic").gameObject;
        sliderFx = volumenFx.transform.Find("SliderFx").gameObject;

        numVolMaster = volumenMaster.transform.Find("NumVolumenMaster").gameObject;
        numVolMus = volumenMusic.transform.Find("NumVolumenMusic").gameObject;
        numVolFx = volumenFx.transform.Find("NumVolumenFx").gameObject;

        //imageMuteMaster = volumenMaster.transform.Find("VolumenMaster").gameObject;;
        velTexto = panelOpciones.transform.Find("VelocidadTexto").gameObject;
        sliderVelTexto = velTexto.transform.Find("SliderVel").gameObject;
        textoVelociad = velTexto.transform.Find("TextoVelocidad").gameObject;
        
        //Pone el Slider de Velocidad Texto en 1
        sliderVelTexto.GetComponent<Slider>().value = 1;

        



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
               
        //El texto que aparece en Velocidad texto es el numero del valor del Slider
        //textoVelociad.GetComponent<TextMeshProUGUI>().text = sliderVelTexto.GetComponent<Slider>().value.ToString();
        
        //Depende del valor del SLider, aparece un texto diferente al que le acompaña la velocidad del efecto de escribir
        if(sliderVelTexto.GetComponent<Slider>().value == 1){
            textoVelociad.GetComponent<TextMeshProUGUI>().text = "Normal";
            Dialogo.velTexto=0.1f;

        }else if(sliderVelTexto.GetComponent<Slider>().value == 0){
            textoVelociad.GetComponent<TextMeshProUGUI>().text = "Lento";
            Dialogo.velTexto=0.2f;

        }else if(sliderVelTexto.GetComponent<Slider>().value == 2){
            textoVelociad.GetComponent<TextMeshProUGUI>().text = "Rápido";
            Dialogo.velTexto=0.01f;
        }

        //Si el Panel Opciones está apagado y pulsas ESC, este se mostrará
        if(Input.GetKeyDown(KeyCode.Escape) && opcionOn==false){
            panelOpciones.SetActive(true);
            opcionOn=true;
            Debug.Log("panel desde tecla: " + opcionOn);
        } else if(Input.GetKeyDown(KeyCode.Escape) && opcionOn==true){
            panelOpciones.SetActive(false);
            opcionOn=false;
            Debug.Log("panel desde tecla: " + opcionOn);
        }
                
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

    public void VolumenMaster(float volume){
        //Debug.Log(volume);
        volMusica = volume;
        voluMusic.SetFloat("volMaster", volume);
        RevisarMuteMaster();
        numVolMaster.GetComponent<TextMeshProUGUI>().text = volMusica.ToString();
    }
    public void VolumenMusica(float volume){
        //Debug.Log(volume);
        volMusica = volume;
        voluMusic.SetFloat("volMusic", volume);
        RevisarMuteMusic();
        numVolMus.GetComponent<TextMeshProUGUI>().text = volMusica.ToString();
    }
    public void VolumenFx(float volume){
        //Debug.Log(volume);
        volMusica = volume;
        voluMusic.SetFloat("volFx", volume);
        RevisarMuteFx();
        numVolFx.GetComponent<TextMeshProUGUI>().text = volMusica.ToString();
    }
  


    public static void AJugar(){
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
        opcionOn=true;
        Debug.Log("panel: " + opcionOn);
    }

    public void OcultarOpciones(){
        //Oculta panel opciones
        panelOpciones.SetActive(false);
        opcionOn=false;
        Debug.Log("panel: " + opcionOn);
    }
}
