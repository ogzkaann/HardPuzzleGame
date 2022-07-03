using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevels : MonoBehaviour
{
    public void LevelOne() { SceneManager.LoadScene("1"); }
    public void LevelTwo() { SceneManager.LoadScene("2"); }
    public void LevelThree() { SceneManager.LoadScene("3"); }
    public void LevelFour() { SceneManager.LoadScene("4"); }
    public void LevelFive() { SceneManager.LoadScene("5"); }

}
