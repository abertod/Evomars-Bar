using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip bandaSonora;
    public AudioClip fxButton;
    AudioSource _audioSource;

    public GameObject musicObj;
    AudioSource audioMusic;


    
    

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

        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = bandaSonora;
        audioMusic.Play();
        audioMusic.loop = false;
        audioMusic.volume = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            audioMusic.Play();
            audioMusic.loop = true;
        }

        if(Input.GetKeyDown(KeyCode.O)){
            audioMusic.Stop();
            audioMusic.loop = false;
        }
    }

        //método para hacer sonar clips de audio
    public void SonarCLipUnaVez(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}

