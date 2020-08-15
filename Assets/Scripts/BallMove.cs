using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody rb;
    public int velocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = float.MaxValue;
        
    }

    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        rb.AddTorque(Vector3.right * Input.GetAxis("Vertical") * 50, ForceMode.Force);
        rb.AddTorque(-Vector3.forward * Input.GetAxis("Horizontal") * 50, ForceMode.Force);
    }
}
