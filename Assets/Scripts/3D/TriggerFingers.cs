using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFingers : MonoBehaviour {
    public Collider leftHand;
    public Collider rightHand;

    void Start () { }

	void Update () {
        if (OVRInput.Get(OVRInput.Touch.PrimaryIndexTrigger, OVRInput.Controller.LTouch)) {
            Debug.Log("(LEFT) Not pointing");
            leftHand.isTrigger = true;
        } else {
            Debug.Log("(LEFT) Pointing");
            leftHand.isTrigger = false;
        }

        if (OVRInput.Get(OVRInput.Touch.PrimaryIndexTrigger, OVRInput.Controller.RTouch)) {
            Debug.Log("(RIGHT) Not pointing");
            rightHand.isTrigger = true;
        } else {
            Debug.Log("(RIGHT) Pointing");
            rightHand.isTrigger = false;
        }
    }
}
