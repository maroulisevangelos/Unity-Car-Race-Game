using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollisions : MonoBehaviour
{
    private AudioSource carExplAudioSource;

    public AudioClip carExplSound;

    void Start()
    {
        carExplAudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (carExplSound != null && carExplAudioSource != null)
        {
            carExplAudioSource.PlayOneShot(carExplSound);
        }

        if (collision.transform.tag == "Obstacles" || collision.transform.tag == "Rock")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
