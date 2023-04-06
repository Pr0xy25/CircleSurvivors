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
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 3f);
        }
        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(rb.velocity.x, -3f);
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-3f, rb.velocity.y);
        }
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(3f, rb.velocity.y);
        }

        if (Input.GetKeyUp("up"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0);
        }
        if (Input.GetKeyUp("down"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0);
        }
        if (Input.GetKeyUp("left"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y);
        }
        if (Input.GetKeyUp("right"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y);
        }
    }
}
