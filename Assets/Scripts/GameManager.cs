using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;

    // Start is called before the first frame update
    private void Start()
    {
        GameOverCanvas.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
}
