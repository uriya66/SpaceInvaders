using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TMP_Text timeField;
    private float time;

    // Update is called once per frame
    void Update()
    {
        time += UnityEngine.Time.deltaTime;
        timeField.text = time.ToString("00:00:00");
    }
}