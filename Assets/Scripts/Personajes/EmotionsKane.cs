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
    public Sprite anotating;
    public Sprite blink;
    public Sprite deeplyAsking;
    public Sprite smirkCejas;
    public Sprite talk;

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
            default:
                sr.sprite = spriteDefault;
            break;
            case "sus":
                sr.sprite = sus;
            break;

            case "smirk":
                sr.sprite = smirk;
            break;

            case "anotating":
                sr.sprite = anotating;
            break;

            case "blink":
                sr.sprite = blink;
            break;

            case "deeply asking":
                sr.sprite = deeplyAsking;
            break;

            case "smirk cejas":
                sr.sprite = smirkCejas;
            break;

            case "talk":
                sr.sprite = talk;
            break;
            
        }




    }


}
