using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementScore : MonoBehaviour
{
    private BirdControl birdControl;
    private bool processed = false;
    private GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        this.birdControl = GameObject.Find("bird").GetComponent<BirdControl>();
        bird = GameObject.Find("bird");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < bird.transform.position.x && !this.processed)
        {
            this.birdControl.incrementScore();
            this.processed = true;
            Debug.Log($"Increment the score: {this.birdControl.getScore()}");
        }
    }
}
