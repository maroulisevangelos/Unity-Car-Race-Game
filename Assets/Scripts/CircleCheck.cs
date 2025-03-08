using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCheck : MonoBehaviour
{
    public int Check = 0;
    public int Check1 = 0;
    public int Check2 = 0;
    public int Check3 = 0;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag == "circleCheck")
        {
            Check = 1;
        }else if (other.transform.tag == "circleCheck1")
        {
            Check1 = 1;
        }else if (other.transform.tag == "circleCheck2")
        {
            Check2 = 1;
        }
        if (other.transform.tag == "circleCheck3")
        {
            Check3 = 1;
        }
    }
}
