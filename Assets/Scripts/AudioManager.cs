using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    //Para llamar al script desde cualquier lado
    public static AudioManager Instance;

    //Añade sonidos
    public AudioClip bandaSonora;
    
    public AudioClip bandaSonora02;
    public AudioClip fxButton;
    AudioSource _audioSource;

    public GameObject musicObj;
    public GameObject musicObj2;
    public static AudioSource audioMusic;
    public static AudioSource audioMusic02;


    Scene escena;
        
    //Patrón Singletón.
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
        
        _audioSource = GetComponent<AudioSource>();
        

        //Aqui se carga la musica 
        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = bandaSonora;
        audioMusic.Play();
        audioMusic.loop = true;
        audioMusic.volume = 1f;


        audioMusic02 = musicObj2.GetComponent<AudioSource>();

        
        
        /*if(tiempo == 4f){
            audioMusic.clip = bandaSonora;
            audioMusic.Play();
            audioMusic.loop = true;
            audioMusic.volume = 1f;
        }*/
        
        audioMusic02 = musicObj2.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //tiempo += Time.deltaTime;
        //Debug.Log(tiempo);
          //audioMusic = musicObj.GetComponent<AudioSource>();
        //Activar musica
        /*
        if(escena.name == "OSalvapantallas"){
            ActivarMusica();
            PararMusica();
        }
        */
        //ActivarMusica();
        //PararMusica();

        if(Input.GetKeyDown(KeyCode.P)){
            audioMusic.Play();
            audioMusic.loop = true;
            audioMusic02.Play();
            audioMusic02.loop = true;
            }
        if(Input.GetKeyDown(KeyCode.O)){
            audioMusic.Pause();
            audioMusic.loop = false;
            audioMusic02.Pause();
            audioMusic02.loop = false;
        }
        

        escena = SceneManager.GetActiveScene();

        if(scene.name == "1Menu"){
            
            audioMusic02 = musicObj2.GetComponent<AudioSource>();
            audioMusic02.clip = bandaSonora02;
            audioMusic02.Play();
            audioMusic02.loop = true;
            audioMusic02.volume = 1f;
        }
        if(scene.name == "2NivelUno"){
            audioMusic.Stop();
            
        }

        //CambioMusica();
    }
    
   /* public void CambioMusica(){
        Debug.Log("OnSceneLoaded: " + scene.name);
        if(scene.name == "1Menu"){
            audioMusic = musicObj.GetComponent<AudioSource>();
            audioMusic.clip = bandaSonora02;
            audioMusic.Stop();
            audioMusic.loop = true;
            }
            if(Input.GetKeyDown(KeyCode.O)){
                audioMusic.Pause();
                audioMusic.loop = false;
            }
        }
        
    }

    public void Escena02(){
    if(escena.name == "1Menu"){
        if(Input.GetKeyDown(KeyCode.P)){
            audioMusic.Play();
            audioMusic.loop = true;
        }
        if(Input.GetKeyDown(KeyCode.O)){
            audioMusic.Stop();
            audioMusic.loop = false;
        }

        audioMusic.Pause();
        audioMusic.clip = banda[1];
        audioMusic.Play();
    }
        
    }

    public void ActivarMusica(){
        if(Input.GetKeyDown(KeyCode.P)){
            audioMusic.Play();
            audioMusic.loop = true;
        }
    }

    public void PararMusica(){
        //Parar musica
        if(Input.GetKeyDown(KeyCode.O)){
            audioMusic.Pause();
            audioMusic.loop = false;
        }
    }*/
    
   
        //método para hacer sonar clips de audio
    public void SonarCLipUnaVez(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}


