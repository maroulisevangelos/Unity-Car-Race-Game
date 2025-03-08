using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    private AudioSource congratsAudioSource;
    public AudioClip congratsSound;
    private float min;
    private float sec;
    private float bestMin;
    private float bestSec;

    void Start()
    {
        float startTime = PlayerPrefs.GetFloat("startTime", 0);
        int Coin = PlayerPrefs.GetInt("Coin", 0);
        float t = Time.time - startTime;

        min = (int)t / 60;
        sec = t % 60 - Coin;

        if (sec < 0)
        {
            min -= 1;
            sec = 60 + sec;
        }

        string minutes = (min).ToString();
        string seconds = (sec).ToString("f1");

        scoreText.text = "YOUR SCORE IS: " + minutes + ":" + seconds;

        if ((PlayerPrefs.HasKey("bestMin")))
        {
            bestMin = PlayerPrefs.GetFloat("bestMin",1000);
            bestSec = PlayerPrefs.GetFloat("bestSec", 100);
        }

        if (!(PlayerPrefs.HasKey("bestMin"))) 
        {
            PlayerPrefs.SetFloat("bestMin", min);
            PlayerPrefs.Save();
            PlayerPrefs.SetFloat("bestSec", sec);
            PlayerPrefs.Save();
            bestMin = min;
            bestSec = sec;
        }
        else if ((min < bestMin) || (min == bestMin && sec < bestSec) )
        {
            PlayerPrefs.SetFloat("bestMin", min);
            PlayerPrefs.Save();
            PlayerPrefs.SetFloat("bestSec", sec);
            PlayerPrefs.Save();
            bestMin = min;
            bestSec = sec;
        }


        string bestMinutes = (bestMin).ToString();
        string bestSeconds = (bestSec).ToString("f1");
        bestScoreText.text = "BEST: " + bestMinutes + ":" + bestSeconds;

        congratsAudioSource = GetComponent<AudioSource>();

        if (congratsSound != null && congratsAudioSource != null)
        {
            congratsAudioSource.PlayOneShot(congratsSound);
        }
    }

    public void Replay()
    {
        PlayerPrefs.SetInt("Coin", 0);
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game!");
    }
}