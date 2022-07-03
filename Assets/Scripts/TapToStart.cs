using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapToStart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (PlayerPrefs.GetInt("Level") == 0)
                PlayerPrefs.SetInt("Level", 1);
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }

    }
}
