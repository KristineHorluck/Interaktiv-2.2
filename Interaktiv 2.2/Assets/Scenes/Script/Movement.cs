using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float Speed;

    public Rigidbody rb;
  void Start()
    {
         rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = transform.right * Input.GetAxisRaw("Horizontal") + transform.forward * Input.GetAxisRaw("Vertical");
        move.Normalize();
        move *= Speed;
        move += new Vector3(0, rb.velocity.y, 0);
        rb.velocity = move;

    }
   
   
}
