using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheel : MonoBehaviour
{
    [SerializeField] private float spinSpeed;
    [SerializeField] private float wheelMotionlessThreshold = 0.5f;

    private Rigidbody2D rb2D;
    private Vector2 lastTouchPos;
    private bool isDragging;
    private bool isSpinning;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !isSpinning)
        {
            print("Touch");
            SpinTheWheel();
        }

        if (isSpinning && Mathf.Abs(rb2D.angularVelocity) < wheelMotionlessThreshold)
        {
            isSpinning = false;
            rb2D.angularVelocity = 0;
        }

        print(Mathf.Abs(rb2D.angularVelocity));
    }

    private void SpinTheWheel()
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            isDragging = true;
            lastTouchPos = touch.position;
        }
        else if (touch.phase == TouchPhase.Moved && isDragging)
        {
            Vector2 delta = touch.position - lastTouchPos;
            float spinForce = delta.x * spinSpeed;
            if (Mathf.Abs(spinForce) > 0.1)
            {
                rb2D.AddTorque(spinForce);
                isSpinning = true;
            }

            lastTouchPos = touch.position;

        }
        else if (touch.phase == TouchPhase.Ended)
        {
            isDragging = false;
        }
    }
}
