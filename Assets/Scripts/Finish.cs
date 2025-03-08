using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CircleCheck circleCheck = GetComponent<CircleCheck>();
        int value = circleCheck.Check;
        int value1 = circleCheck.Check1;
        int value2 = circleCheck.Check2;
        int value3 = circleCheck.Check3;

        if (other.transform.tag == "Finishline" && value == 1 && value1 == 1 && value2 == 1 && value3 == 1)
        {
            GameObject.Find("Car").SendMessage("Finish");
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

}
