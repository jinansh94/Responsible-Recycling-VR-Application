using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanText : MonoBehaviour {

   

    public Canvas EscCan;

    void Start()
    {
        //Find the object you're looking for
        GameObject tempObject = GameObject.Find("Can_Green");
        if (tempObject != null)
        {
            //If we found the object , get the Canvas component from it.
           
            if (EscCan == null)
            {
                Debug.Log("Could not locate Canvas component on " + tempObject.name);
            }
            else
            {
                Debug.Log("got it");
            }
        }
    }


}
