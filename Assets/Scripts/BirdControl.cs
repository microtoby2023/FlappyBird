using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float BaseVelocity;

    public GameManager Gm;

    public int Score { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update if called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * BaseVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Gm.GameOver();
    }


    public void incrementScore()
    {
        this.Score++;
    }

    public int getScore()
    {
        return this.Score;
    }
}
