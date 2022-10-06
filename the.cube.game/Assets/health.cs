using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    int CHP = 100;
    public int MHP = 100;
    private void OnJointBreak2D(Joint2D joint)
    {

    }
    private void OnJointBreak(float breakForce)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
            takeDamage(12);
    }


        public void takeDamage(int damage)
    {
        CHP -= damage;
        print("Ouch you hurt me my health is now" + CHP);
    }

    internal int whatsYourMaxHealth()
    {
        return MHP;
    }
}
