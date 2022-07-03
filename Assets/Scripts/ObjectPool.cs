using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private GameObject prefab;
    private Stack<GameObject> objectPool = new Stack<GameObject>();

    public ObjectPool(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void FillPool(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject obj = Object.Instantiate(prefab);
            AddObject(obj);
        }
    }

    public GameObject GetObject()
    {
        if (objectPool.Count > 0)
        {
            GameObject obj = objectPool.Pop();
            obj.gameObject.SetActive(true);

            return obj;
        }

        return Object.Instantiate(prefab);
    }

    public void AddObject(GameObject obj)
    {
        obj.gameObject.SetActive(false);
        objectPool.Push(obj);
    }
}
