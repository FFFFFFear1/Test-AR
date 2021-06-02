using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressFillObject : MonoBehaviour
{
    Material objectMaterial;

    private void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
        var progressBorder = GetComponent<MeshFilter>().mesh.bounds.size.y / 2;
        objectMaterial.SetFloat("ProgressBorder", progressBorder);
        objectMaterial.SetFloat("FillRate", -progressBorder);
    }
}
