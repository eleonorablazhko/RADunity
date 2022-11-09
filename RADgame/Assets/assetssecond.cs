using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assetssecond : MonoBehaviour
{


    public Transform projectileCloneTemplate;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Transform newTransform = Instantiate(projectileCloneTemplate, transform.position, transform.rotation);

            Rigidbody newObjectRigidbody = newTransform.GetComponent<Rigidbody>();
            newObjectRigidbody.AddExplosionForce(1000,
                transform.position - transform.forward - transform.up, 3);

        }
    }
}

