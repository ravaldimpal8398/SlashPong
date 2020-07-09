using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenView : MonoBehaviour
{
    Canvas canvas;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
    public virtual void Show()
    {

        canvas.enabled = true;
    }
    public virtual void Hide()
    {

        canvas.enabled = false;
    }
    public virtual void Disable()
    {

        canvas.enabled = false;
    }
}
