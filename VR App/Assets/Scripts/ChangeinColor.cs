using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeinColor : MonoBehaviour {

    public Material original;
    public Material changed_Material;
   
    public void Start()
    {

        GetComponent<Renderer>().material = original;
     
    }

    public void looking()
    {
        //GetComponent<Text>().SetAc
        GetComponent<Renderer>().material = changed_Material;
     

    }
    public void notLooking()
    {
        GetComponent<Renderer>().material = original;
      

    }
}
