using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysCounterText : MonoBehaviour
{
    public int keys;
    public Text keyCounter;

    void Update()
    {
        keyCounter.text = (keys + "/4");
    }
}
