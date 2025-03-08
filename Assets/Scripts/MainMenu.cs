using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject info;

    void Start()
    {
        AudioListener.volume = 1;
        info.SetActive(false);
    }

    public void Play()
    {
        PlayerPrefs.SetInt("Coin", 0);
        PlayerPrefs.Save();
        PlayerPrefs.DeleteKey("bestMin");
        PlayerPrefs.Save();
        PlayerPrefs.DeleteKey("bestSec");
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Info()
    {
        info.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game!");
    }

    public void Back()
    {
        info.SetActive(false);
    }
}
