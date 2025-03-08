using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAudio : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    public AudioClip soundClip;
    private float currentSpeed;

    private Rigidbody carRb;
    private AudioSource carAudio;

    public float minPitch;
    public float maxPitch;
    private float pitchFromCar;

    void Start()
    {
        carAudio = GetComponent<AudioSource>();
        carRb = GetComponent<Rigidbody>();
        carAudio.clip = soundClip;

        // Set loop to false initially
        carAudio.loop = false;

        // Start playing the sound
        carAudio.Play();
    }

    void Update()
    {
        // Check if the sound has finished playing
        if (!carAudio.isPlaying)
        {
            // If it has finished, play it again
            carAudio.Play();
        }
        EngineSound();
    }

    void EngineSound()
    {
        currentSpeed = carRb.velocity.magnitude;
        pitchFromCar = carRb.velocity.magnitude / 60f;

        if (currentSpeed < minSpeed)
        {
            carAudio.pitch = minPitch;
        }

        if (currentSpeed > minSpeed && currentSpeed < maxSpeed)
        {
            carAudio.pitch = (minPitch + pitchFromCar) * currentSpeed;
        }

        if (currentSpeed > maxSpeed)
        {
            carAudio.pitch = maxPitch;
        }
    }
}