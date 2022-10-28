using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capitalcontrol : MonoBehaviour
{ float turningSpeed = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * Time.deltaTime;
       
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.A)) 
            transform.position -= transform.right * Time.deltaTime;
        
       

        if (Input.GetKey(KeyCode.J))
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.L))
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.I))
            transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.K))
            transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);

       


    }

}
