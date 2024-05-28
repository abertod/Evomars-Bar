using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmotionsKane : MonoBehaviour
{

    SpriteRenderer sr;

    public Sprite spriteDefault;
    public Sprite sus;
    public Sprite smirk;

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
            case "sus":
                sr.sprite = sus;
            break;

            case "smirk":
                sr.sprite = smirk;
            break;
            
            default:
                sr.sprite = spriteDefault;
            break;
        }




    }


}
