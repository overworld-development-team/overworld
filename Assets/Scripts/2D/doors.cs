using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class doors : MonoBehaviour {

    public bool triggerDoor = false;

    void Start () {

    }

    void Update()
    {

    }
   

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.tag == "Player") {
            
            triggerDoor = true;
            //Debug.Log("trigger door " + triggerDoor);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            triggerDoor = false;
            //Debug.Log("trigger door " + triggerDoor);
        }
    }
}
