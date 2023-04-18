using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float rotationSpeed;
    void Update()
    {
        float horizontaInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontaInput * rotationSpeed * Time.deltaTime);
    }
}
