using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderGraphFill : MonoBehaviour
{
    private float _FillRateValue = 0.65f;
    private float progressBorder = 2.5f;
    
    Material objectMaterial;

    void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
        objectMaterial.SetFloat("FillRate", _FillRateValue);
        objectMaterial.SetFloat("ProgressBorder", progressBorder);
    }
    
    public void ChangeValue(float value)
    {
        if (value < 0.65f)
            objectMaterial.SetFloat("FillRate", 1.3f - value);
    }
}
