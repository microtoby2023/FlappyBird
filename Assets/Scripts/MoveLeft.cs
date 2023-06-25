using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector2.left * this.Speed * Time.deltaTime);
    }
}
