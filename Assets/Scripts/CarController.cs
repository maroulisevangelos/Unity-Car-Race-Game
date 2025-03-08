/**using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 50.0f; // The speed of the car
    private float rotationSpeed = 100.0f; // The speed of the car's rotation
    private float horizontalInput; // The horizontal input (left and right arrow keys)
    private float verticalInput; // The vertical input (up and down arrow keys)

    private void Update()
    {
        // Get the horizontal and vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // Move the car forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotate the car left and right
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);

    }
}**/

using UnityEngine;
using System;
using System.Collections.Generic;

public class CarController : MonoBehaviour
{
    /**public enum ControlMode
    {
        Keyboard,
        Buttons
    };**/

    public enum Axel
    {
        Front,
        Rear
    }

    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        //public GameObject wheelEffectObj;
        //public ParticleSystem smokeParticle;
        public Axel axel;
    }

    //public ControlMode control;

    public float maxAcceleration = 40.0f;
    public float brakeAcceleration = 50.0f;

    public float turnSensitivity = 2.0f;
    public float maxSteerAngle = 60.0f;

    public Vector3 _centerOfMass;

    public List<Wheel> wheels;

    float moveInput;
    float steerInput;

    private Rigidbody carRb;


    void Start()
    {
        carRb = GetComponent<Rigidbody>();
        carRb.centerOfMass = _centerOfMass;
        AudioListener.volume = 1;
    }

    void Update()
    {
        GetInputs();
    }

    void LateUpdate()
    {
        Move();
        Steer();
    }

    public void MoveInput(float input)
    {
        moveInput = input;
    }

    public void SteerInput(float input)
    {
        steerInput = input;
    }

    void GetInputs()
    {
        moveInput = Input.GetAxis("Vertical");
        steerInput = Input.GetAxis("Horizontal");    
    }

    void Move()
    {
        foreach (var wheel in wheels)
        {
            wheel.wheelCollider.motorTorque = moveInput * maxAcceleration * 20;
            transform.Translate(Vector3.forward * Time.deltaTime * moveInput * maxAcceleration / 3);
        }
    }

    void Steer()
    {
        foreach (var wheel in wheels)
        {
            if (wheel.axel == Axel.Front)
            {
                var _steerAngle = steerInput * turnSensitivity * maxSteerAngle;
                wheel.wheelCollider.steerAngle = Mathf.Lerp(wheel.wheelCollider.steerAngle, _steerAngle, 0.6f);
            }
        }
    }
}