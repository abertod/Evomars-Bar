using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class popUpController : MonoBehaviour
{
    public Animator popUpAnimator;
    public bool activado = false;

    int sweet = 0;
    double sweetCosa = 0;
    int sour = 0;
    double sourCosa = 0;
    int spicy = 0;
    double spicyCosa = 0;
    int cool = 0;
    double coolCosa = 0;

    public GameObject barra1;
    public GameObject barra2;
    public GameObject barra3;
    public GameObject barra4;


    // Update is called once per frame
    void Update()
    {
        if(sweet > sweetCosa)
        {
            sweetCosa += 1f;
            barra1.transform.localScale += new Vector3(1, 0, 0);
        }
        
        if (sour > sourCosa)
        {
            sourCosa += 1f;
            barra2.transform.localScale += new Vector3(1, 0, 0);
        }

        if (spicy > spicyCosa)
        {
            spicyCosa += 1f;
            barra3.transform.localScale += new Vector3(1, 0, 0);
        }

        if (cool > coolCosa)
        {
            coolCosa += 1f;
            barra4.transform.localScale += new Vector3(1, 0, 0);
        }


    }

    public void animarPopUp()
    {
        activado = !activado;
        popUpAnimator.SetBool("Activado", activado);
        
    }


    public void clickCoctelera()
    {
        sweet = 0;
        cool = 0;
        sour = 0;
        spicy = 0;
        sweetCosa = 0;
        coolCosa = 0;
        sourCosa = 0;
        spicyCosa = 0;
        barra1.transform.localScale = new Vector3(150, 0.6F, 0.75963F);
        barra2.transform.localScale = new Vector3(150, 0.6F, 0.75963F);
        barra3.transform.localScale = new Vector3(150, 0.6F, 0.75963F);
        barra4.transform.localScale = new Vector3(150, 0.6F, 0.75963F);
    }

    public void clickCerezas()
    {
        if (sweet <= 400)
        {
            sweet += 50;
        }
    }
    public void clickAceite()
    {
        if (cool <= 400)
        {
            cool += 50;
        }
    }
    public void clickBotellaVerde()
    {
        if (sour <= 400)
        {
            sour += 50;
        }
    }
    public void clickBotellaRoja()
    {
        if (spicy <= 400)
        {
            spicy += 50;
        }
    }



}
