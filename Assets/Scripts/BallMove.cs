using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        rb.AddForce(Vector3.forward * Input.GetAxis("Vertical") * 200, ForceMode.Force);
        rb.AddForce(Vector3.right * Input.GetAxis("Horizontal") * 200, ForceMode.Force);
    }
}
