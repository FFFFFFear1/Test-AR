using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public bool isMoon;
    public Vector3 angle;
    
    private float rotateSpeed = 5;
    
    void FixedUpdate()
    {
        gameObject.transform.Rotate(angle.x, isMoon ? 1 - Mathf.Sin(Time.time) : angle.y, isMoon ? 1 + Mathf.Sin(Time.time) : angle.z);
    }
    
    private void OnMouseDrag()
    {
        var rotY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
        var rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        
        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);
    }
}
