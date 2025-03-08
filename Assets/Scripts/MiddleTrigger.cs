using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public GameObject FinalTrig;
    public GameObject MiddleTrig;

    void OnTriggerEnter()
    {
        FinalTrig.SetActive(true);
        MiddleTrig.SetActive(false);
    }
}
