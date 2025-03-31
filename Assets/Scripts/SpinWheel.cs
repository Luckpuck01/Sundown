using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheel : MonoBehaviour
{
    [SerializeField] private float spinSpeed;

    private Rigidbody2D rb2D;
    private Vector2 lastTouchPos;
    private bool isDragging;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.touches);
    }
}
