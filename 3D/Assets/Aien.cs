using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Aien : MonoBehaviour
{
    private Animator anim;
    public float speed;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");
        Debug.Log($"X --> {x}, Y --> {y}");
        if (x == 0 && y == 0)
            anim.SetBool("Walking", false);
        else {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y + speed, transform.position.z) * Time.deltaTime;
            anim.SetBool("Walking", true); 
        }

  
    }
}
