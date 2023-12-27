using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public virtual void DisplayText() => Debug.Log($"I'm a ??? cube!");

    private void OnMouseDown()
    {
        DisplayText();
    }
}
