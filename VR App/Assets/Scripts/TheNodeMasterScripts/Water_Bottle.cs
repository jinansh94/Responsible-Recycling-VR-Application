using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Bottle : MonoBehaviour {
    public Rigidbody TheBall;
    public Transform TheHolder;
    public GameObject AllTheNodes;



    // The Old Holding Script
    public void InMyHands()
    {
        Debug.Log("water bottle handsssssssssssssssssssssssssssssssssssssssssssss");
        TheBall.transform.parent = TheHolder.transform;
        TheBall.transform.localPosition = TheHolder.transform.localPosition;

        AllTheNodes.SetActive(true);

    }


    // The Old Dropping Script
    public void OnTheNodes()
    {
        Debug.Log("water bottle handsssssssssssssssssssssssssssssssssssssssssssssxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        TheBall.transform.parent = null;
        TheBall.transform.localPosition = TheHolder.transform.localPosition;

        GameObject.Find("Bottle_Water").SetActive(false);
        AllTheNodes.SetActive(false);

    }
}
