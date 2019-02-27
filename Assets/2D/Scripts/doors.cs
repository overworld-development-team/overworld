using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class doors : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("COLLIDE");
        if (Input.GetKey(KeyCode.Return) && col.tag == "bedroomDoor") {
            CanvasGroup room1 = GetComponent<CanvasGroup>();
            room1.alpha = 0f;
        }
    }
}
