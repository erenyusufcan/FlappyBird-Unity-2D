using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float MaxTime;
    private float time;
    public bool isPlaying;

    void Start()
    {
        GameObject newpipe=Instantiate(pipe);
        float y_location = Random.Range(0, 3);
        newpipe.transform.position = new Vector3(7,y_location,0);
        isPlaying = true;
    }

    
    void Update()
     {
        if (isPlaying) { 
        if(time > MaxTime)
        {
            GameObject newpipe= Instantiate(pipe);
            float y_location = Random.Range(0, 3);
            newpipe.transform.position = new Vector3(7, y_location, 0);
            time = 0;
        }

        time += Time.deltaTime;
            
        }
      
    }
    public void PipeCollision()
    {
        isPlaying = false;
    }
}
