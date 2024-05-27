using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmotionsKane : MonoBehaviour
{

    SpriteRenderer sr;

    public Sprite spriteDefault;
    public Sprite enfadado;
    public Sprite contento;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void SetEmotion(string emotion){

        switch (emotion)
        {
            case "enfadado":
                sr.sprite = enfadado;
            break;

            case "contento":
                sr.sprite = contento;
            break;
            
            default:
                sr.sprite = spriteDefault;
            break;
        }




    }


}
