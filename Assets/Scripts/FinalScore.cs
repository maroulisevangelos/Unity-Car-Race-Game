using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    public GameObject FinalTrig;
    public GameObject MiddleTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    
    //public GameObject FinalScoreBox;


    void OnTriggerManager ()
    {
        if (TimeCounter.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + TimeCounter.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + TimeCounter.SecondCount + ".";
        }

        if (TimeCounter.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + TimeCounter.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + TimeCounter.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + TimeCounter.MilliCount;

        TimeCounter.MinuteCount = 0;
        TimeCounter.SecondCount = 0;
        TimeCounter.MilliCount = 0;

        MiddleTrig.SetActive(true);
        FinalTrig.SetActive(false);
    }

}
