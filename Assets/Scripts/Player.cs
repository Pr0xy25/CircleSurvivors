using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 3f);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(rb.velocity.x, -3f);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-3f, rb.velocity.y);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(3f, rb.velocity.y);
        }

        if (Input.GetKeyUp("w"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0);
        }
        if (Input.GetKeyUp("s"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0);
        }
        if (Input.GetKeyUp("a"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y);
        }
        if (Input.GetKeyUp("d"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y);
        }

    }
}
