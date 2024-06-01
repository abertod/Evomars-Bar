using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Servir_Prep : MonoBehaviour
{
    public GameObject prepararBebida;
    public GameObject reiniciarBebida;
    public ObjetosSeleccionables objetosSeleccionables;

    // Start is called before the first frame update
    void Start()
    {
        prepararBebida = GameObject.Find("Preparar_Bebida"); 
        prepararBebida.SetActive(false);

        reiniciarBebida = GameObject.Find("Reiniciar_Bebida"); 
        reiniciarBebida.SetActive(false);

        objetosSeleccionables = GameObject.Find("Bebida_1").GetComponent<ObjetosSeleccionables>();
        
    }
    public void ApareceBotonServir(){
        if(objetosSeleccionables.sumaTotal == 0){
            prepararBebida.SetActive(false);
            reiniciarBebida.SetActive(false);

        }
        if(objetosSeleccionables.sumaTotal >= 1){
            prepararBebida.SetActive(true);
            reiniciarBebida.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        ApareceBotonServir();
    }
}
