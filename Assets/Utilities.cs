using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static async void WaitAsync(int delayinms, Action actiontoperform)
    {
        await Task.Delay(delayinms);

        if (actiontoperform != null)
        {
            actiontoperform();
        }
    }
}
