using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TubeSpawner : MonoBehaviour
{
    public GameObject TubePairPrefab;
    public float OffsetY;
    public float OffsetX;
    public float SpawnInterval;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnTube", SpawnInterval, 1.0f);
    }

    private void SpawnTube()
    {
        GameObject newTupe = Instantiate(this.TubePairPrefab, transform.position, transform.rotation);
        MoveLeft tupeControl = newTupe.GetComponent<MoveLeft>();
        if (OffsetX > tupeControl.Speed * SpawnInterval / 2) OffsetX = MathF.Max(0, tupeControl.Speed * SpawnInterval / 2 - 0.1f);
        newTupe.transform.position = transform.position + new Vector3(Random.Range(-OffsetX, OffsetX), Random.Range(-OffsetY, OffsetY), 0);
        Destroy(newTupe, SpawnInterval * 5);
    }
}
