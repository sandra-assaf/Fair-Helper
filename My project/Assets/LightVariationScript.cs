using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightVariationScript : MonoBehaviour
{
    public float minIntensity;
    private float initialIntensity;
    public Light2D light;
    public float timeSkip;
    private float timeElapsed = 0;
    void Start()
    {
        initialIntensity = light.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > timeSkip)
        {
            light.intensity = Random.Range(minIntensity, initialIntensity);
            timeElapsed = 0;
        }
        
    }
}
