using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
        else
        {
            Debug.LogError("Gyroscope not supported on this device!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.gyro.enabled)
        {
            float zRotation = Input.gyro.rotationRateUnbiased.z;  
            transform.Rotate(0, 0, -zRotation * rotationSpeed * Time.deltaTime); 
        }
    }
}