using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public int Coin = 0;
    private AudioSource coinAudioSource;

    public TextMeshProUGUI coinText;
    public AudioClip coinSound;

    void Start()
    {
        coinAudioSource = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "CoinB")
        {
            if (coinSound != null && coinAudioSource != null)
            {
                coinAudioSource.PlayOneShot(coinSound);
            }
            Coin++;
            coinText.text = "Coins: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.Save();
        }
        else if (other.transform.tag == "Coin")
        {
            if (coinSound != null && coinAudioSource != null)
            {
                coinAudioSource.PlayOneShot(coinSound);
            }
            Coin = Coin + 2;
            coinText.text = "Coins: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coin", Coin);
            PlayerPrefs.Save();
        }
    }
}
