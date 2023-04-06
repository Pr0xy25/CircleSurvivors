using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("EnemySpawn", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EnemySpawn()
    {
        int location = Random.Range(0, 3);
        
        if (location == 0)
        {
            Instantiate(monster, new Vector3(Random.Range(-8f, 8f), 6f, 0), transform.rotation);
        }
        else if (location == 1)
        {
            Instantiate(monster, new Vector3(Random.Range(-8f, 8f), -6f, 0), transform.rotation);
        }
        else if (location == 2)
        {
            Instantiate(monster, new Vector3(9f, Random.Range(-5f, 5f), 0), transform.rotation);
        }
        else if (location == 3)
        {
            Instantiate(monster, new Vector3(-9f, Random.Range(-5f, 5f), 0), transform.rotation);
        }

        Invoke("EnemySpawn", 2);
    }
}
