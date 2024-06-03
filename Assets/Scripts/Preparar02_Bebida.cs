using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class Preparar02_Bebida : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    // Color más transparente al pasar el ratón
    public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 

    

    public ApareceBebidasKoemi apareceBebidasKoemi;
    public ObjetosSeleccionables objetosSeleccionables;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;

        

        
    }

    void OnMouseDown()
    {
        //Esta función se activará cuando el jugador haga clic en la imagen
        Seleccionar();
        apareceBebidasKoemi.Aparecen02Bebidas();
        apareceBebidasKoemi.Aparecen02ImagenesPreparación();
        
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[1]);

        Debug.Log("Has seleccionado: "  + objetosSeleccionables.sumaAcido + " de Ácido, "
                                        + objetosSeleccionables.sumaDulce + " de Dulce, " 
                                        + objetosSeleccionables.sumaPicante + " de Picante, " 
                                        + objetosSeleccionables.sumaTotal + " entre todas."  );
        
        ConversationManager.Instance.SetInt("Acido", objetosSeleccionables.sumaAcido);
        ConversationManager.Instance.SetInt("Dulce", objetosSeleccionables.sumaDulce);
        ConversationManager.Instance.SetInt("Picante", objetosSeleccionables.sumaPicante);
        ConversationManager.Instance.SetInt("Total", objetosSeleccionables.sumaTotal);
    }

    void OnMouseEnter()
    {
        //Cuando el ratón entra en el objeto
        spriteRenderer.color = colorAlPasarElRaton;
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[0]);
    }

    void OnMouseExit()
    {
        //Cuando el ratón sale del objeto
        spriteRenderer.color = colorOriginal;
    }

    
    void Seleccionar()
    {
        //Aquí se realizará la selección
        Debug.Log("Imagen seleccionada: " + gameObject.name);
        //reiniciarBebida.SetActive(false);
        //Aqui se pondrá que el valor de la bebida haciendose vuelva a cero
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
