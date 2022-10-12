using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubegeneratorscript : MonoBehaviour
{
    public Transform cubetemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {


        }                                                                                                                                                                  


            if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubetemplate, 
                                transform.position - transform.forward,
                                Quaternion.identity);
        }


    }
}
