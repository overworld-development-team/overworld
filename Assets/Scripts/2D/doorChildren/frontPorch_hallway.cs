﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontPorch_hallway : doors {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && triggerDoor == true)
        {
            gameManager2D.Instance.levelPos = new Vector3(712f, 0f, 0f);
            gameManager2D.Instance.playerPos = new Vector3(-768f, -315.1f, 0f);
            gameManager2D.Instance.playerScale = new Vector3(10f, 10f, 10f);
            gameManager2D.Instance.ActiveLevel = 2;
        }
    }
}
