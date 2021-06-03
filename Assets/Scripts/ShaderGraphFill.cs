using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderGraphFill : MonoBehaviour
{
    public Slider slider;
    private float fillRateValue;
    private float progressBorder = 2.5f;
    private float borderPlanet = 0.65f;
    private float maxRange = 1.3f;
    
    Material objectMaterial;

    void Start()
    {
        fillRateValue = borderPlanet;
        
        if (slider.value < borderPlanet)
            objectMaterial.SetFloat("FillRate", maxRange - slider.value);
        
        objectMaterial = GetComponent<Renderer>().material;
        objectMaterial.SetFloat("FillRate", fillRateValue);
        objectMaterial.SetFloat("ProgressBorder", progressBorder);
    }
    
    public void ChangeValue()
    {
        if (slider.value < borderPlanet)
            objectMaterial.SetFloat("FillRate", maxRange - slider.value);
    }
}
