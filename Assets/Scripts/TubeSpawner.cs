using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    public GameObject TubePairPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnTube", 1.0f, 1.0f);
    }

    private void SpawnTube()
    {
        Instantiate(this.TubePairPrefab, transform.position, transform.rotation);
    }
}
