using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hallway_front : doors {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && triggerDoor == true)
        {
            gameManager2D.Instance.levelPos = new Vector3(-1.54f, 171f, 0f);
            gameManager2D.Instance.playerPos = new Vector3(3f, -162f, 0f);
            gameManager2D.Instance.playerScale = new Vector3(7f, 7f, 7f);
            gameManager2D.Instance.ActiveLevel = 4;
        }
    }
}
