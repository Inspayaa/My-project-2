using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    private float topBound;
    private float lowwerBound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //setting top and bottom boundary for animals
        topBound = 30f;
        lowwerBound = -10f;

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowwerBound)
        {
            //destroys out-of-bounds and console print Gameover 
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
