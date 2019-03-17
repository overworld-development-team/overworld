using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

        //Go to first level when player presses A + X
        if (OVRInput.Get(OVRInput.Button.One) && OVRInput.Get(OVRInput.Button.Three))
        {
            gameManager2D.Instance.levelPos = new Vector3(0f, 0f, 0f);
            gameManager2D.Instance.playerPos = new Vector3(-792.63f, -315.1f, 0f);
            gameManager2D.Instance.playerScale = new Vector3(10f, 10f, 10f);
            gameManager2D.Instance.ActiveLevel = 1;
        }
    }
}
