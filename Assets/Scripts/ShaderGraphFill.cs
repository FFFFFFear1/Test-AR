using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderGraphFill : MonoBehaviour
{
    // [SerializeField] private float progressSteps = 10f;

    // private float _FillRateValue;
    // private float progressBorder;
    // private float stepSize;
    
    Material objectMaterial;

    void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
        // progressBorder = GetComponent<MeshFilter>().mesh.bounds.size.y / 2;
        // _FillRateValue = -progressBorder;
        // objectMaterial.SetFloat("FillRate", _FillRateValue);
        // stepSize = (2 * progressBorder) / progressSteps;
    }


    public void ChangeValue(float value)
    {
        if (value < 0.63f)
            objectMaterial.SetFloat("FillRate", 1.3f - value);
    }
}
