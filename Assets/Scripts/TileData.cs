using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData : MonoBehaviour
{
    public int Height => _height;
    public int Width => _width;
    public int StepCount => _stepCount;

    private int _height;
    private int _width;

    private int _stepCount;

    public void SetHeight(int height)
    {
        _height = height;
        Debug.Log(height + "Height");
    }

    public void SetWidth(int width)
    {
        _width = width;
        Debug.Log(width + "Width");
    }

    public void SetStepCount(int count)
    {
        _stepCount = count;
    }
}
