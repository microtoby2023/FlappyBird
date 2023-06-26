using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreDisplay : MonoBehaviour
{
    private BirdControl birdControl;

    // Start is called before the first frame update
    void Start()
    {
        birdControl = GameObject.Find("bird").GetComponent<BirdControl>();
    }

    // Update is called once per frame
    void Update()
    {
        var s = GetComponent<TextMeshProUGUI>();
        s.text = $"Score: {birdControl.Score}";
    }
}
