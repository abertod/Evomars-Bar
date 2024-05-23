using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionaSOnido : MonoBehaviour
{
    public AudioClip musica;
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
