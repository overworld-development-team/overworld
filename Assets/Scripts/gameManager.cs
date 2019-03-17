using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public static gameManager Instance;

    float actionTimer;
    float eventTime = 0f;

    /*public GameObject rotator1;
    public GameObject rotator2;
    public GameObject rotator3;
    public GameObject rotator4;*/
    //public Light flashlight;
    public Light roomlight;

    void Awake()
    {
        Instance = this;
    }

    void Start () {

    }

	void Update () {
        //timer for actions requiring button input
        actionTimer += Time.deltaTime;


        /*//ROTATOR LOCK
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
                    } else { Debug.Log("Rotator 4 false"); }
                } else { Debug.Log("Rotator 3 false"); }
            } else { Debug.Log("Rotator 2 false"); }
        } else { Debug.Log("Rotator 1 false"); }
        //END ROTATOR LOCK*/

        /*//FLASHLIGHT
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
        //END FLASHLIGHT*/

    }
}
