using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float baseVelocity;

    public GameManager Gm;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        baseVelocity = 0.75f;
    }

    // Update if clled once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * baseVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Gm.GameOver();
    }
}
