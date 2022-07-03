using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnTime = 3f;
    public int size;
    public TextMeshProUGUI text;

    void Start()
    {
        StartCoroutine(ObjectCycle());
    }

    IEnumerator ObjectCycle()
    {
        for (int i = 0; i < size; i++)
        {
            Object.Instantiate(prefab, transform.position, transform.rotation);
            text.text = ""+(i+1);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
   
