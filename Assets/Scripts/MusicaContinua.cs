using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaContinua : MonoBehaviour
{
    public static MusicaContinua Instance;
    public AudioClip musica;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        

    }
    // Start is called before the first frame update
    void Start()
    {
      
       AudioManager.Instance.SonarMusica(musica);
       
    
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
