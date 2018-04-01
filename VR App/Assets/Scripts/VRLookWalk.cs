using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

    public Transform vrcamera;

    public float toggleangle = 355.0f;

    public float speed = 3.0f;
    public bool moveforward;

    private CharacterController cc;

	
	void Start () {

        cc = GetComponentInParent<CharacterController>();
		
	}
	
	
	void Update () {
        if (vrcamera.eulerAngles.x <= toggleangle && vrcamera.eulerAngles.x>270)
        {
           
            moveforward = true;
        } 
        else
        {
            
            moveforward = false;
        }
        if (moveforward)
        {
            
            Vector3 forward = vrcamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
	}
}
