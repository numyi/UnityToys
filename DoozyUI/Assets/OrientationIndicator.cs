﻿using Doozy.Engine.Orientation;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrientationIndicator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOrientationEvent(DetectedOrientation orientation)
    {
        this.GetComponent<TextMeshProUGUI>().text = orientation.ToString();
    }
}
