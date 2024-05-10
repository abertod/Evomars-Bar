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
    AudioSource audioMusic;


    
    
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
        audioMusic.loop = false;
        audioMusic.volume = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        //Activar musica
        if(Input.GetKeyDown(KeyCode.P)){
            audioMusic.Play();
            audioMusic.loop = true;
        }
        //Parar musica
        if(Input.GetKeyDown(KeyCode.O)){
            audioMusic.Stop();
            audioMusic.loop = false;
        }

        /*
        if(Menu.AJugar() = true){
            audioMusic.clip = bandaSonora02;
        }
        */
    }

        //método para hacer sonar clips de audio
    public void SonarCLipUnaVez(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}

