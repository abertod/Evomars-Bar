using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Salvapantallas : MonoBehaviour
{
    //variable para texto de pulsar cualquier tecla
    public GameObject textoIni;
    //Panel opcional de escribir tu nombre
    public GameObject panel_Nombre;
    

    
     

    // Start is called before the first frame update
    void Start()
    {
        //pulsar cualquier tecla
        textoIni = GameObject.Find("PulsaTeclas");
        //escribir tu nombre empieza desactivado
        panel_Nombre = GameObject.Find("Panel_Nombre");
        panel_Nombre.SetActive(false);

        

    }

      // Update is called once per frame
    void Update()
    {
        //Pulsa cualquier tecla (falta que texto parpadee)
        textoIni.GetComponent<TextMeshProUGUI>().text = "Pulsa cualquier tecla";
        //activa panel del nombre
        if(Input.anyKeyDown){
            panel_Nombre.SetActive(true);
        }
        
    }

    public void AMenu(){
        //Carga el menu
        SceneManager.LoadScene("1Menu");
    }

    public void SuenaBoton(){
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fxButton);
    }

    

}
    



