﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour {

    public GameObject myCube;
    public Vector3 newScale; 

	// Use this for initialization
	void Start () {
        myCube.transform.localScale = newScale;
        //myCube.transform.eulerAngels = newRotation;
        //myCube.transform.position = newPosition;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
