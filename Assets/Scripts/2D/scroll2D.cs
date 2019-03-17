using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll2D : MonoBehaviour {

    public GameObject player;
    public float speed;
    public float offset;
    private float playerX;
    private float levelX;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void LateUpdate () {
        if (player)
        {
            playerX = player.GetComponent<RectTransform>().localPosition.x;
        } else
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        RectTransform rt = GetComponent<RectTransform>();
        RectTransform mD = GameObject.Find("monitorDraw").GetComponent<RectTransform>();

        if (((rt.rect.width - mD.rect.width)/2 + rt.localPosition.x) > 20 && playerX > offset)
        {
            rt.Translate(-speed/5 * Time.deltaTime, 0.0f, 0.0f);
        }
        if (((rt.rect.width - mD.rect.width) / 2 - rt.localPosition.x) > 20 && playerX < -offset)
        {
            rt.Translate(speed/5 * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
