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
    public static AudioSource audioMusic;
    public static AudioSource audioMusic02;


    Scene scene;
     LoadSceneMode mode;
    
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
        
    }

    // Update is called once per frame
    void Update()
    {
        //Activar musica
        if(Input.GetKeyDown(KeyCode.P)){
            audioMusic.Play();
            audioMusic.loop = true;
            //Debug.Log("Esta sonando "+ bandaSonora);
        }
        //Parar musica
        if(Input.GetKeyDown(KeyCode.O)){
            audioMusic.Stop();
            audioMusic.loop = false;
        }

        scene = SceneManager.GetActiveScene();

        if(scene.name == "0Salvapantallas"){
            audioMusic02 = musicObj.GetComponent<AudioSource>();
            audioMusic02.clip = bandaSonora02;
            audioMusic02.Play();
            audioMusic02.loop = true;
            audioMusic02.volume = 1f;
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
            audioMusic.volume = 1f;
        }
        
        
    }*/
/*
    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        if(){
        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = bandaSonora02;
        audioMusic.Play();
        audioMusic.loop = true;
        audioMusic.volume = 1f;
        }

        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log("OnSceneLoadedmmmmmmm: " + mode);
    }
*/
   
        //método para hacer sonar clips de audio
    public void SonarCLipUnaVez(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}

