using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour
{
    public AK.Wwise.Event footsteps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            footsteps.Post(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            footsteps.Post(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            footsteps.Post(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            footsteps.Post(gameObject);
        }

        if (Input.GetKeyUp(KeyCode.W)) 
        { 
            footsteps.Stop(gameObject); 
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            footsteps.Stop(gameObject);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            footsteps.Stop(gameObject);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            footsteps.Stop(gameObject);
        }


    }
}
