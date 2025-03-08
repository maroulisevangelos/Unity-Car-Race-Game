using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime;
    private bool finished = false;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI bestTimerText;

    private float bestMin;
    private float bestSec;
    private int flag;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        PlayerPrefs.SetFloat("startTime", startTime);
        PlayerPrefs.Save();
        if ((PlayerPrefs.HasKey("bestMin")))
        {
            bestMin = PlayerPrefs.GetFloat("bestMin");
            bestSec = PlayerPrefs.GetFloat("bestSec");
            flag = 1;
        }
        else
        {
            flag = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
        {
            return;
        }

        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f1");

        timerText.text = minutes + ":" + seconds;

        if (flag == 0)
        {
            bestTimerText.text = minutes + ":" + seconds;
        } else 
        {
            string bestMinutes = (bestMin).ToString();
            string bestSeconds = (bestSec).ToString("f1");

            bestTimerText.text = bestMinutes + ":" + bestSeconds;
        }
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.red;
    }
}
