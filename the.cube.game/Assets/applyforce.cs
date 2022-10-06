using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyforce : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ourRigidBody.AddForce(Vector3.right);
        }

        if (Input.GetKey(KeyCode.W))
        {
            ourRigidBody.AddForce(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ourRigidBody.AddForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.S))
        {
            ourRigidBody.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(500, transform.position = Vector3.down, 2);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        health objectHitHealth = collision.gameObject.GetComponent<health>();

        if (objectHitHealth)
        {
            print("Found health script in order hit");
            objectHitHealth.takeDamage(3);

            int ObjectsMaxHealth = objectHitHealth.whatsYourMaxHealth();
            if (ObjectsMaxHealth > 100)
                objectHitHealth.takeDamage(100);
        }
        else
        {
            print("Didn't find the health script in object hit");
        }


      
    }
}
    