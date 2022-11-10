using System.Collections;
using System.Collections.Generic;
using UnityEngine;


{
    private object ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ourRigidBody.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ourRigidBody.AddForce(Vector3.back);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ourRigidBody.AddForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ourRigidBody.AddForce(Vector3.right);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ourRigidBody.AddForce(Vector3.right);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            ourRigidBody.AddExplosionForce(1000, transform.position + Vector3.down + Vector3.back, 2);
        }
    }
   { 
}
{ 
    
}
