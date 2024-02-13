using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Aien : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    public float speed;
    public float speedRotation = 5;

    private bool death = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (death == true) return;

        if (Input.GetKey(KeyCode.W))
            {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            anim.SetBool("Walking",true);
            rb.velocity = transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            rb.velocity = -transform.forward * speed;
            anim.SetBool("Backwards", true);
        }
        else
        {
            anim.SetBool("Walking", false);
            anim.SetBool("Backwards", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0)  * speedRotation, Space.World);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0)  * speedRotation, Space.World);
        }

        if (Input.GetKey(KeyCode.M))
        {
            anim.SetBool("Death", true);
            death = true;
        }
    }
}
