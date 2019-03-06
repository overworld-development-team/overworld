using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class doors : MonoBehaviour {

    public GameObject rotator1;
    public GameObject rotator2;
    public GameObject rotator3;
    public GameObject rotator4;
    public GameObject character;
    public RawImage bg;
    public Texture doorclosed;
    public Texture dooropen;
    public Texture overworld;

    void Start () {
        bg.texture = doorclosed;
	}

	void Update () {
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
                    } else { Debug.Log("Rotator 4 false"); }
                } else { Debug.Log("Rotator 3 false"); }
            } else { Debug.Log("Rotator 2 false"); }
        } else { Debug.Log("Rotator 1 false"); }

        if (OVRInput.Get(OVRInput.Button.Two) && character.transform.position.x > 700)
        {
            bg.texture = overworld;
            // THIS IS WHERE IT CHANGES THE ROOM TO OVERWORLD TITLE SCREEN
        }
	}
}
