using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileData
{
    public int Height => _height;
    public int Width => _width;
    public int StepCount => _stepCount;

    int _height;
    int _width;

    int _stepCount;

    public TileData(int height, int width)
    {
        _height = height;
        _width = width;
    }

    public void SetStepCount(int count)
    {
        _stepCount = count;
    }
}
