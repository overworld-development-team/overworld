using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using Oculus.Avatar;

public class movement : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    public OvrAvatarDriver Driver;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //OVRInput.FixedUpdate();
    }

    void LateUpdate()
    {
        //OVRInput.Update();
    } 

    void Update()
    {
        
        //OVRInput.Update();
        //left and right
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f); }

        Vector2 thumbstick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch);

        //Debug.Log(thumbstick);

        transform.Translate(thumbstick[0] * Time.deltaTime, 0.0f, 0.0f);

        // jump
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && OnGround()) GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpspeed );

    }

    //ground detection for jump
    bool OnGround()
    {
        float distance = 0.015f;

        Vector2 bottom = new Vector2(
            GetComponent<BoxCollider2D>().bounds.center.x,
            GetComponent<BoxCollider2D>().bounds.min.y - distance);

        RaycastHit2D hit = Physics2D.Raycast(
            bottom,
            -Vector2.up,
            distance);

        if (hit.collider == null)
            return false;
        else if (hit.collider.isTrigger)
            return false;
        else
            return true;
    }
}
