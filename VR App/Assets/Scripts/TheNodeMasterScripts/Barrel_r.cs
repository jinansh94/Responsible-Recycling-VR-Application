using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel_r : MonoBehaviour {
    public Rigidbody TheBall;
    public Transform TheHolder;
    public GameObject AllTheNodes;




    // The Old Holding Script
    public void InMyHands()
    {

        TheBall.transform.parent = TheHolder.transform;
        TheBall.transform.localPosition = TheHolder.transform.localPosition;

        AllTheNodes.SetActive(true);

    }


    // The Old Dropping Script
    public void OnTheNodes()
    {

        TheBall.transform.parent = null;
        TheBall.transform.localPosition = TheHolder.transform.localPosition;

        GameObject.Find("barrel").SetActive(false);

        AllTheNodes.SetActive(false);

    }
}
