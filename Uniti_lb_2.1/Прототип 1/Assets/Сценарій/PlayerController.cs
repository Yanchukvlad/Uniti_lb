using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal") ;
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardInput); // rux tanky
       transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed* horizontalInput);

    }
}
