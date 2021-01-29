using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_occlusion : MonoBehaviour
{
    public GameObject cam;
    RaycastHit rh;
    public LayerMask lm;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distanceToCamera = Vector3.Distance(transform.position, cam.transform.position);
        var TargetDirection = cam.transform.position - transform.position;
        Physics.Raycast(transform.position, TargetDirection, out rh, distanceToCamera, lm);


        if (rh.collider)
        {
            Debug.DrawLine(transform.position, cam.transform.position, Color.red);
            AkSoundEngine.SetRTPCValue("Occlusion", 100f, gameObject);
        }

        else
         
        {
            Debug.DrawLine(transform.position, cam.transform.position, Color.green);
            AkSoundEngine.SetRTPCValue("Occlusion", 0f, gameObject);
        }
    }
}
