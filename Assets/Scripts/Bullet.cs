using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Monster")
        {
            Monster monster = other.gameObject.GetComponentInChildren<Monster>();

            if (monster.health > 1)
            {
                monster.health--;
            }
            else if (monster.health <= 1)
            {
                Destroy(other.gameObject);
            }

            Destroy(this.gameObject);
        }
    }
}
