using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginTriggerScript : MonoBehaviour
{
    public GameObject BeginTrigger;
    public GameObject FinalTrigger;

    void OnTriggerEnter() {
        FinalTrigger.SetActive(true);
        FinalTrigger.SetActive(false);
    }
}
