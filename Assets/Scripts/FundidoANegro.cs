using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundidoANegro : MonoBehaviour
{
    public GameObject Fundido;
    public GameObject[] ListaFundida;
    public GameObject cosaT;
    public Animator fundirAnim;



    private void Awake()
    {
        foreach(GameObject fundir in ListaFundida)
        {
            fundir.SetActive(false);
        }
        Color tmp = Fundido.GetComponent<SpriteRenderer>().color;
        tmp.a = 1f;
        Fundido.GetComponent<SpriteRenderer>().color = tmp;
    }
    public void fundirFundido()
    {
        foreach (GameObject fundir in ListaFundida)
        {
            fundir.SetActive(true);
        }

        fundirAnim.SetBool("fundir", true);
    }

    public void alLobyLaT()
    {
        cosaT.SetActive(false);
    }
}
