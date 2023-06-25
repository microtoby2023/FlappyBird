using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    public Vector2 spawnPosition;
    public GameObject tubePairPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnTube", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnTube()
    {
        Instantiate(this.tubePairPrefab);
    }
}
