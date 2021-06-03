using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderGraphFill : MonoBehaviour
{
    public Slider slider;
    private float _FillRateValue = 0.65f;
    private float progressBorder = 2.5f;
    
    Material objectMaterial;

    void Start()
    {
        if (slider.value < 0.65f)
            objectMaterial.SetFloat("FillRate", 1.3f - slider.value);
        
        objectMaterial = GetComponent<Renderer>().material;
        objectMaterial.SetFloat("FillRate", _FillRateValue);
        objectMaterial.SetFloat("ProgressBorder", progressBorder);
    }
    
    public void ChangeValue()
    {
        if (slider.value < 0.65f)
            objectMaterial.SetFloat("FillRate", 1.3f - slider.value);
    }
}
