using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialGaeTimer : MonoBehaviour {

    public float myTime = 0f;
    public Transform radialProgress;
    public GameObject TheStuffToDo;
    public string TheMagicWord;

  

    // Use this for initialization
    public void Start()
    {
        Debug.Log("bread coming");
        radialProgress.GetComponent<Image>().fillAmount = myTime;
        Debug.Log("braed outming");
    }

    // Update is called once per frame
    public void Update()
    {

        myTime += Time.deltaTime;
        radialProgress.GetComponent<Image>().fillAmount = myTime/2;
        if (myTime >= 2f)
        {


            Debug.Log("circle fare");
            DoStuff();
            Debug.Log("circle na fare");



        }
    }

    public void Reset()
    {
        myTime = 0f;
        radialProgress.GetComponent<Image>().fillAmount = myTime;
    }

    public void DoStuff()
    {
        
        if (TheMagicWord == ("HAND"))
        {
            Debug.Log("hath ma ave");
            TheStuffToDo.GetComponent<TheNodeMaster>().InMyHands();
        }

        else if (TheMagicWord == "NODE") {
            Reset();
            TheStuffToDo.GetComponent<TheNodeMaster>().OnTheNodes();
           
        }
    }


    }
