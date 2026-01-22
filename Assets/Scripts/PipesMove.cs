using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMove : MonoBehaviour
{
    public float speed;
    public PipeSpawn PipeSpawn;

    public void Start()
    { 
         PipeSpawn = FindObjectOfType<PipeSpawn>();
    }
    void Update()
    {

        if (PipeSpawn.isPlaying)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

    }
}
