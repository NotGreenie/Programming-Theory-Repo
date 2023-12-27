using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    [SerializeField] private GameObject cube;
    public string cubeColour
    {
        get { return cube.name; }
        set { cube.name = value; }
    }

    // POLYMORPHISM
    public override void DisplayText() => Debug.Log($"I'm a {cubeColour}");
}