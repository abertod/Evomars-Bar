using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reiniciar_Bebida : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    // Color más transparente al pasar el ratón
    public Color colorAlPasarElRaton = new Color(1f, 1f, 1f, 0.5f); 

    

    public ApareceBebidas apareceBebidas;
    

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
        apareceBebidas.AparecenImagenesPreparación();
        AudioManager.Instance.SonarCLipUnaVez(AudioManager.Instance.fx[1]);
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
