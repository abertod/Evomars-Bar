using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Salvapantallas : MonoBehaviour
{
    public GameObject textoIni;
    public GameObject panel_Nombre;
    

    
     

    // Start is called before the first frame update
    void Start()
    {
        textoIni = GameObject.Find("PulsaTeclas");
        panel_Nombre = GameObject.Find("Panel_Nombre");

        panel_Nombre.SetActive(false);

        

    }

      // Update is called once per frame
    void Update()
    {
        textoIni.GetComponent<TextMeshProUGUI>().text = "Pulsa cualquier tecla";

        if(Input.anyKeyDown){
            panel_Nombre.SetActive(true);
        }
        
    }

    public void AMenu(){
        SceneManager.LoadScene("1Menu");
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
    }

    

}
    



