using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour {

    public GameObject myCube;

    public Vector3 scaleVector;


	// Use this for initialization
	void Start ()
    {


	}
	
	// Update is called once per frame
	void Update ()
    {

        myCube.transform.localScale += scaleVector;
        //myCube.transform.position += movementVector;
        //myCube.transform.eulerAngles += rotationVector;
    }
}
