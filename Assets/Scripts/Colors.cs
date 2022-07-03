using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colors : MonoBehaviour
{
    private TargetController target;
    public enum Coloring
    {
        RED,
        GREEN,
        BLUE,
        YELLOW,
        PURPLE,
        ORANGE,
        BLACK,
        WHITE,
        AQUA,
        PINK
    };

    public Coloring color;
    public Color red, green, blue, yellow, purple, orange, black, white, aqua, pink;

    void Start()
    {
        target = this.gameObject.GetComponent<TargetController>();
        if(target == null)
        {
            color = Utilities.RandomEnumValue<Coloring>((SceneManager.GetActiveScene().buildIndex * 2));
        }
        PickColor();
    }

    private void PickColor()
    {
        switch (color)
        {
            case Coloring.RED:
                GetComponent<SpriteRenderer>().color = red;
                break;
            case Coloring.GREEN:
                GetComponent<SpriteRenderer>().color = green;
                break;
            case Coloring.BLUE:
                GetComponent<SpriteRenderer>().color = blue;
                break;
            case Coloring.YELLOW:
                GetComponent<SpriteRenderer>().color = yellow;
                break;
            case Coloring.PURPLE:
                GetComponent<SpriteRenderer>().color = purple;
                break;
            case Coloring.ORANGE:
                GetComponent<SpriteRenderer>().color = orange;
                break;
            case Coloring.BLACK:
                GetComponent<SpriteRenderer>().color = black;
                break;
            case Coloring.WHITE:
                GetComponent<SpriteRenderer>().color = white;
                break;
            case Coloring.AQUA:
                GetComponent<SpriteRenderer>().color = aqua;
                break;
            case Coloring.PINK:
                GetComponent<SpriteRenderer>().color = pink;
                break;
        }
    }
}
