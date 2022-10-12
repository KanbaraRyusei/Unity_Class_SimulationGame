using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OnClickManager
{
    public static int StepCount { get; private set; }

    public static void OnClick(Tile tile)
    {
        StepCount = tile.TileData.StepCount;
    }
}
