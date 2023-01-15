using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public List<GameObject> pipes;
    public GameObject pipe;
    public float spawnTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipesAtRight", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnPipesAtRight()
    {
        float randomOffset = Random.Range(-2f, 2f);
        pipe = Instantiate(pipe);
        pipe.transform.position = new Vector3(12.0f, randomOffset, 0.0f);
        pipes.Add(pipe);
        RemoveOldPipes();
    }

    void RemoveOldPipes()
    {
        List<GameObject> oldPipes = new List<GameObject>();

        foreach (var pipe in pipes)
        {
            if (pipe.transform.position.x < -13f)
            {
                oldPipes.Add(pipe);
                Destroy(pipe);
            }
        }

        pipes = pipes.Except(oldPipes).ToList();
    }
}
