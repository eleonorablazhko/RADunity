using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubecontrol : MonoBehaviour

{

    float speed = 10f;
    float roatationspeed = 90;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position -= transform.forward * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime;
            transform.Rotate(Vector3.up, 5f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
            transform.Rotate(Vector3.up, 5f);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
            transform.Rotate(Vector3.up, 5f);
            transform.Rotate(transform.right, -5f);
        }




    }
}