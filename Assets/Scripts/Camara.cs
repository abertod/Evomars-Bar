using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Camera cam;
    public float parallaxVelocidad = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        Vector3 mousePos = Input.mousePosition;
            {
                 Ray ray = cam.ScreenPointToRay(mousePos);
                Debug.Log("Eje X " + mousePos.x + "   Eje Y " + mousePos.y);
                //Debug.Log("Eje Y " + mousePos.y);
            }
        //Debug.Log("FixedUpdate");
        transform.position = new Vector3(Camera.main.transform.position.x/parallaxVelocidad, Camera.main.transform.position.y/parallaxVelocidad, 0);
    }
}
