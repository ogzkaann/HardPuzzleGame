using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float distance;
    public Transform cornerDetection;
    private bool _trueMatch = false;
    private BallManager bm;

    private void Start()
    {
        bm = GameObject.Find("GameManager").GetComponent<BallManager>();

    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        CornerDetection(90);
    }

    private void CornerDetection(int rotate)
    {
        LayerMask mask = LayerMask.GetMask("Corner");
        RaycastHit2D cornerInfo = Physics2D.Raycast(cornerDetection.position, transform.TransformDirection(Vector2.up), distance, mask);
        Debug.DrawRay(cornerDetection.position, transform.TransformDirection(Vector2.up), Color.green);

        if (cornerInfo.collider != null)
        {
            if (cornerInfo.collider.gameObject.GetComponent<Colors>() != null)
            {
                if (gameObject.GetComponent<Colors>().color == cornerInfo.collider.gameObject.GetComponent<Colors>().color)
                {
                    _trueMatch = true;
                }
                else
                {
                    _trueMatch = false;
                }
            }
            else
            {
                transform.Rotate(0, 0, rotate);
                CornerDetection(180);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name != "ChangeRoad"){
            if (_trueMatch)
            {
                bm.totalTrueBall++;
                PlayerPrefs.SetInt("HighScore", bm.totalTrueBall);
            }
            Destroy(gameObject);
        }
    }
}
