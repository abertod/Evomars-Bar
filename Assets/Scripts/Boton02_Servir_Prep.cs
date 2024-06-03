using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton02_Servir_Prep : MonoBehaviour
{
    public GameObject prepararBebida02;
    public GameObject reiniciarBebida02;
    public ObjetosSeleccionables objetosSeleccionables;

    // Start is called before the first frame update
    void Start()
    {
        prepararBebida02 = GameObject.Find("Preparar_Bebida02"); 
        prepararBebida02.SetActive(false);

        reiniciarBebida02 = GameObject.Find("Reiniciar_Bebida02"); 
        reiniciarBebida02.SetActive(false);

        objetosSeleccionables = GameObject.Find("Picante").GetComponent<ObjetosSeleccionables>();
        
    }
    public void ApareceBotonServir(){
        if(objetosSeleccionables.sumaTotal == 0){
            prepararBebida02.SetActive(false);
            reiniciarBebida02.SetActive(false);

        }
        if(objetosSeleccionables.sumaTotal >= 1){
            prepararBebida02.SetActive(true);
            reiniciarBebida02.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        ApareceBotonServir();
    }
}
