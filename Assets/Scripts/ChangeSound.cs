using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    public bool isOn = true;

    // Start is called before the first frame update
    void Start()
    {
        soundOnImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            AudioListener.volume = 0;
        } else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioListener.volume = 1;
        }
    }
}
