using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform mainChar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainChar);

       if (Input.GetKey(KeyCode.L));
        transform.position += Vector3.right * Time.deltaTime;

       if (Input.GetKey(KeyCode.J));
        transform.position += Vector3.left * Time.deltaTime;

       if(Input.GetKey(KeyCode.I))
         transform.position += Vector3.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.K))
            transform.position += Vector3.down * Time.deltaTime;
    }
}
