using UnityEngine;
using System;

public class InputEvents : MonoBehaviour
{
    public event Action<float> OnHorizontalAxis;
    public event Action<float> OnVerticalAxis;

    public void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            OnVerticalAxis.Invoke(Input.GetAxis("Vertical"));
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            OnHorizontalAxis.Invoke(Input.GetAxis("Horizontal"));
        }
    }
}
