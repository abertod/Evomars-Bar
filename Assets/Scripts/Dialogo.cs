using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public static Dialogo Instance;
    public TextMeshProUGUI dialogoTexto;
    public string[] lineas;
    public static float velTexto;
    int index;


    // Start is called before the first frame update
    void Start()
    {
        lineas = new string[7]{
        "aa aa a a a  a a a a aaa aa a a a  a a a a aaa aa a a a  a a a a aaa aa a a a  a a a a a  ",
        "bbb bb bb bb bb b bbb b b b b b bb bb b b b bb bb bbb bb bbbbbb b b bb bb b bb b b b b b bb b b b b ",
        "cccc c c c cccc c c ccccc c c ccccc c c ccccc c c ccccc c c ccccc c c ccccc c c ccccc c c c",
        "aa aa a a a  a a a a a aa aa a a a  a a a a aaa aa a a a  a a a a aaa aa a a a  a a a a aaa aa a a a  a a a a a",
        "bbb bb bb bb bb b bbb bbb bb bb bb b bbb bbb bb bb bb b bbb bbb bb bb bb b bbb bbb bb bb bb b bbb b",
        "cccc c c c  c c c cccc c c ccccc c c ccccc c c c cccc c c ccccc c c ccccc c c c cccc c c ccccc c c ccccc",
        "ssfdgsdg zfbkjdsvn djnvksdvlkjsdndvk cjx vzlnc lsjddvk<avñk k sdvñkl <sgv<klv kzxolkzx  xvoklzs kd"
    };

        dialogoTexto.text = string.Empty;
        EmpiezaDialogo();

        Debug.Log(velTexto);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)){
            if(dialogoTexto.text == lineas[index]){
                SigLinea();
            }else{
                StopAllCoroutines();
                dialogoTexto.text = lineas[index];
            }
        }
    }

    public void EmpiezaDialogo(){
        index = 0;

        StartCoroutine (EscribeLinea());
    }

    IEnumerator EscribeLinea(){
        foreach (char letras in lineas[index].ToCharArray()){
            dialogoTexto.text += letras;
            yield return new WaitForSeconds(velTexto);
        }
    }

    public void SigLinea(){
        if (index < lineas.Length -1){
            index++;
            dialogoTexto.text = string.Empty;
            StartCoroutine (EscribeLinea());
        }else{
            gameObject.SetActive(false);
        }
    }
}
