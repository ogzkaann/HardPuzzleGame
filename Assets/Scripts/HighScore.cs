using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        text.text = "Your Score: " + PlayerPrefs.GetInt("HighScore");
    }
}
