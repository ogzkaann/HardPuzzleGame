using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    private void OnMouseDown()
    {
        bool active = transform.GetChild(0).gameObject.activeSelf;
        transform.GetChild(0).gameObject.SetActive(!active);
        transform.GetChild(1).gameObject.SetActive(active);
    }
}
