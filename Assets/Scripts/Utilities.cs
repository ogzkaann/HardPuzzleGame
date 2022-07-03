using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static T RandomEnumValue<T>(int range) 
    {
        var values = Enum.GetValues(typeof(T));
        int random = UnityEngine.Random.Range(0, range);
        return (T)values.GetValue(random);
    }
}
