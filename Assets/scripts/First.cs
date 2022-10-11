
using System;
using UnityEngine;

public class First : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = -1000f;
    public float sideways = 350f;

    private void FixedUpdate()
    {
        rb.AddForce(forwardforce*Time.deltaTime,0,0);
        if (Input.GetKey("d"))
        {
            rb.AddForce(0,0,sideways* Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0,0,-sideways* Time.deltaTime,ForceMode.VelocityChange);
        }

        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}