using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class tintineoEstrella : MonoBehaviour
{
    public float frecuenciaTintineo = 1;
    private Light2D luz2D;
    public float potenciaTintineo = 1;

    // Start is called before the first frame update
    void Start()
    {
        luz2D = GetComponent<Light2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log (Mathf.PerlinNoise(Time.time*frecuenciaTintineo, 0.0f));
        float intensidad = Mathf.PerlinNoise(Time.time, 0.0f);
        luz2D.intensity = intensidad*potenciaTintineo;
    }
}
