using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusGrab : MonoBehaviour {

    public GameObject CollidingObject;
    public GameObject objectInHand;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0.2 && CollidingObject)
        {
            GrabObject();
        }
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) < 0.2 && objectInHand)
        {
            ReleaseObject();
        }
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0.2 && CollidingObject)
        {
            GrabObject();
        }
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) < 0.2 && objectInHand)
        {
            ReleaseObject();
        }
    }

    //On Collision
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            CollidingObject = other.gameObject;
            Debug.Log("Object and Controller Collided");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        CollidingObject = null;
    }

    //Grab Object
    public void GrabObject() //create parentchild relationship between object and hand so object follows hand
    {
        objectInHand = CollidingObject;
        objectInHand.transform.SetParent(this.transform);
        objectInHand.GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log("Object Grabbed");
    }

    //Release Object
    private void ReleaseObject() //removing parentchild relationship so you drop the object
    {
        objectInHand.GetComponent<Rigidbody>().isKinematic = false;
        objectInHand.transform.SetParent(null);
        objectInHand = null;
        Debug.Log("Object Released");
    }
}
