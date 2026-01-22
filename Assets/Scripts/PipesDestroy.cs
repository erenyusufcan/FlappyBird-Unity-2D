using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesDestroy : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.x < -4)
        {
            Destroy(gameObject);
        }
    }
}
