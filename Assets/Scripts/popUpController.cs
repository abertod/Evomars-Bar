using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class popUpController : MonoBehaviour
{
    public Animator popUpAnimator;
    public bool activado = false;


    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown("space")) 
        {             
            animarPopUp();               
        }
        */

    }

    public void animarPopUp()
    {
        activado = !activado;
        popUpAnimator.SetBool("Activado", activado);
        
    }
}
