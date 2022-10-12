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
        if (Input.GetKey(KeyCode.UpArrow))
        transform.position += Vector3.up * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += Vector3.down * Time.deltaTime;
       
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * Time.deltaTime;
      
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.up * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.down * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += Vector3.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.Z))
            transform.position += Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.R))
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.C))
            transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.X))
            transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);

       


    }

}
