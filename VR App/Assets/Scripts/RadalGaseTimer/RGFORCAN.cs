using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RGFORCAN : MonoBehaviour {
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


          
            
                    DoStuff();
          

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

            TheStuffToDo.GetComponent<Can>().InMyHands();
        }

        else if (TheMagicWord == "NODE")
        {
            Reset();
            TheStuffToDo.GetComponent<Can>().OnTheNodes();

        }
    }


}
