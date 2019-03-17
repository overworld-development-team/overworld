using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenameThis : doors {

    /*------------------------------------
     * 
     * Instructions to use this template
     * 1. Duplicate this file and rename it
     * 2. Rename class name ^^^ to match filename
     * 3. Change the settings below
     * 4. Right-click the level you want to add this to (In the hierarchy, NOT prefab)
     * 5. Add "Box Collider 2D". Adjust collision box as needed. Enable "Is trigger".
     * 6. Add this script.
     * 7. Save Prefab (Drag from hierarchy ontop of previous prefab file in "Project" tab.
     * 
     * -----------------------------------*/


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && triggerDoor == true)
        {
            gameManager2D.Instance.levelPos = new Vector3(-1.54f, 171f, 0f); //Level's position relative to canvas
            gameManager2D.Instance.playerPos = new Vector3(751f, -315.1f, 0f); //Player avatar's position relative to canvas
            gameManager2D.Instance.playerScale = new Vector3(10f, 10f, 10f); //Player avatar's scale. Default: new Vector3(10f, 10f, 10f)
            gameManager2D.Instance.ActiveLevel = 4; //Which level? Go to the "manager" GameObject > "gameManager2D" script component > "level" serialized field
        }
    }
}
