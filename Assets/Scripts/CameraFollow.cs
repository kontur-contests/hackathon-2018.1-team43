using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraFollow : NetworkBehaviour
{
    public GameObject Target;
    public Vector3 Offset;


    // Use this for initialization
    void Start ()
	{
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Target != null)
        {
            var newPosition = Target.transform.position + Offset;
            transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
        }
    }
}
