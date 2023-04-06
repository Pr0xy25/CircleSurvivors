using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    GameObject player;
    Vector3 target;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // Player Tracking
        target = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        //crosshairs.transform.position = new Vector2(target.x, target.y);



        Vector3 difference = player.transform.position - this.transform.position;
        float distance = difference.magnitude;
        Vector2 direction = difference / distance;
        direction.Normalize();

        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        this.GetComponent<Rigidbody2D>().velocity = direction * 2.5f;
    }
}
