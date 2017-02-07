﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTexture : MonoBehaviour
{

    public Vector2 speed;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Renderer>().material.mainTextureOffset += speed * Time.deltaTime;
    }
}
