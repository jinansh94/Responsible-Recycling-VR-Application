using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGFORBAR : MonoBehaviour {

    public float myTime = 0f;
    public Transform radialProgress;
    public GameObject TheStuffToDo;
    public string TheMagicWord;



    // Use this for initialization
    public void Start()
    {
        radialProgress.GetComponent<Image>().fillAmount = myTime;

    }

    // Update is called once per frame
    public void Update()
    {

        myTime += Time.deltaTime;
        radialProgress.GetComponent<Image>().fillAmount = myTime / 2;
        if (myTime >= 2f)
        {

            Debug.Log("water bottle coming");

            DoStuff();




        }
    }

    public void Reset()
    {
        myTime = 0f;
        radialProgress.GetComponent<Image>().fillAmount = myTime;
        Debug.Log("water bottle reset");
    }

    public void DoStuff()
    {

        if (TheMagicWord == ("HAND"))
        {
            Debug.Log("water bottle hands");
            TheStuffToDo.GetComponent<Barrel_r>().InMyHands();
        }

        else if (TheMagicWord == "NODE")
        {
            Debug.Log("water bottle sdasdasdsadadasdasdasdasdasds");
            Reset();
            TheStuffToDo.GetComponent<Barrel_r>().OnTheNodes();

        }
    }
}
