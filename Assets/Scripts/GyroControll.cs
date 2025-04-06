using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private GyroWarning warning;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (warning.isCalibrated)
        {
            //sif (Input.gyro.enabled)
            {
                float zRotation = Input.gyro.rotationRateUnbiased.z;
                transform.Rotate(0, 0, -zRotation * rotationSpeed * Time.deltaTime);
            }
        }
    }
}