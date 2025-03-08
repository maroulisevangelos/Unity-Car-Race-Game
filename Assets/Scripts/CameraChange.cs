using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject secondarycamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("MainCamera"))
        {
            maincamera.SetActive(true);
            secondarycamera.SetActive(false);
        }else if (Input.GetButtonDown("SecondaryCamera"))
        {
            maincamera.SetActive(false);
            secondarycamera.SetActive(true);
        }
    }
}
