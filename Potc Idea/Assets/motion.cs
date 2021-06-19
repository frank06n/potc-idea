using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    Rigidbody shipRigidbody;
    public float shipForce;

    // Start is called before the first frame update
    void Awake()
    {
        shipRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            shipRigidbody.AddForce(transform.forward * shipForce * Time.fixedDeltaTime);
        }
    }
}
