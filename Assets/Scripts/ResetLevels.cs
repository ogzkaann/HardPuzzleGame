using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevels : MonoBehaviour
{
    private void OnMouseDown() { 
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene(1);
    }
}
