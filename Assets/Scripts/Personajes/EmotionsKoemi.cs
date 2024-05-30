using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionsKoemi : MonoBehaviour
{

    SpriteRenderer sr;

    public Sprite spriteDefault;
    public Sprite sonrisaNoTilted;
    public Sprite sonrisa;
    public Sprite sorpresa;
    public Sprite talk;
    public Sprite worriedOpen;
    public Sprite worried;



    // Start is called before the first frame update
    void Start()
    {
        
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
            case "sonrisa no tilted":
                sr.sprite = sonrisaNoTilted;
            break;

            case "sonrisa":
                sr.sprite = sonrisa;
            break;

            case "sorpresa":
                sr.sprite = sorpresa;
            break;

            case "talk":
                sr.sprite = talk;
            break;

            case "worried open":
                sr.sprite = worriedOpen;
            break;

            case "worried":
                sr.sprite = worried;
            break;
        }
    }

}
