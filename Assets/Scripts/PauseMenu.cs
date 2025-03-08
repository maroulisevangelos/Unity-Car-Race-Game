using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public ChangeSound changeSound;
    bool isOn;

    public void Pause()
    {
        isOn = changeSound.isOn;
        if (isOn)
        {
            AudioListener.volume = 0.3f;
        }
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isOn = changeSound.isOn;
        if (isOn)
        {
            AudioListener.volume = 1;
        }
    }

    public void Restart()
    {
        PlayerPrefs.SetInt("Coin", 0);
        PlayerPrefs.Save();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
