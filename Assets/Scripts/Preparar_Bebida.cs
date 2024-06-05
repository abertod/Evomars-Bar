using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class Preparar_Bebida : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    // Color más transparente al pasar el ratón
    public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 

    

    public ApareceBebidas apareceBebidas;
   
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
        apareceBebidas.AparecenBebidas();
        //apareceBebidas.AparecenImagenesPreparación();
        //apareceBebidas.Aparecen02Bebidas();
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[1]);
        Debug.Log("Has seleccionado: "  + objetosSeleccionables.sumaAcido + " de Ácido, "
                                        + objetosSeleccionables.sumaDulce + " de Dulce, " 
                                        + objetosSeleccionables.sumaPicante + " de Picante, "
                                        + objetosSeleccionables.sumaSweet + " de Sweet, " 
                                        + objetosSeleccionables.sumaTotal + " entre todas."  );
        
        ConversationManager.Instance.SetInt("Acido", objetosSeleccionables.sumaAcido);
        ConversationManager.Instance.SetInt("Dulce", objetosSeleccionables.sumaDulce);
        ConversationManager.Instance.SetInt("Picante", objetosSeleccionables.sumaPicante);
        ConversationManager.Instance.SetInt("Sweet", objetosSeleccionables.sumaSweet);
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
       
        Debug.Log("Imagen seleccionada: " + gameObject.name);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
