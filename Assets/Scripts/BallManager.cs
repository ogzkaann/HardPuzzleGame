using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallManager : MonoBehaviour
{
    public PlayerController[] balls;
    public int totalTrueBall;
    public TextMeshProUGUI text;

    void Update()
    {
        balls = FindObjectsOfType<PlayerController>();
        text.text = "" + totalTrueBall;
        if (balls.Length == 0)
        {
            NextLevel();
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
