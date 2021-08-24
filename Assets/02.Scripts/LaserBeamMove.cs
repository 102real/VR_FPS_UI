using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeamMove : MonoBehaviour
{
    public float thrust = 1000f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = transform.forward * thrust;
        Destroy(gameObject, 2f);
    }
}
