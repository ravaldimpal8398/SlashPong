﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 360) * 2 * Time.deltaTime, 0.5f);
    }
}
