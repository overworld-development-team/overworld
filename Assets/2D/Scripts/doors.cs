using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class doors : MonoBehaviour {

    float actionTimer;
    float eventTime = 0f;

    public GameObject rotator1;
    public GameObject rotator2;
    public GameObject rotator3;
    public GameObject rotator4;
    public GameObject character;
    public RawImage bg;
    public Texture doorclosed;
    public Texture dooropen;
    public Texture title;
    private bool triggerDoor = false;
    private bool advance = false;
    public Light flashlight;
    public Light roomlight;

    void Start () {
        bg.texture = doorclosed;
        roomlight.intensity = 1.5f;
        flashlight.intensity = 0;
    }

	void Update () {
        actionTimer += Time.deltaTime;
        //Debug.Log(actionTimer);

        if (rotator1.transform.eulerAngles.x > -15 && rotator1.transform.eulerAngles.x < 15)
        {
            Debug.Log("Rotator 1 true");
            if (rotator2.transform.eulerAngles.x > -15 && rotator2.transform.eulerAngles.x < 15)
            {
                Debug.Log("Rotator 2 true");
                if (rotator3.transform.eulerAngles.x > -15 && rotator3.transform.eulerAngles.x < 15)
                {
                    Debug.Log("Rotator 3 true");
                    if (rotator4.transform.eulerAngles.x > -15 && rotator4.transform.eulerAngles.x < 15)
                    {
                        Debug.Log("Rotator 4 true");
                        bg.texture = dooropen;
                        advance = true;
                    } else { Debug.Log("Rotator 4 false"); }
                } else { Debug.Log("Rotator 3 false"); }
            } else { Debug.Log("Rotator 2 false"); }
        } else { Debug.Log("Rotator 1 false"); }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            if(advance == true && triggerDoor == true)
            {
                bg.texture = title;
                character.SetActive(false); // false to hide, true to show
                Debug.Log("Exit");
            }
        }
        if (OVRInput.Get(OVRInput.Button.Three) && ((actionTimer - eventTime) > 0.5f))
        { if (flashlight.intensity < 1)
            {
                roomlight.intensity = 0;
                flashlight.intensity = 1;
                eventTime = actionTimer;
            } else
            {
                roomlight.intensity = 1.5f;
                flashlight.intensity = 0;
                eventTime = actionTimer;
            }
        } 

    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.tag == "Player") {
            
            triggerDoor = true;
            Debug.Log("trigger door " + triggerDoor);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            triggerDoor = false;
            Debug.Log("trigger door " + triggerDoor);
        }
    }
}
