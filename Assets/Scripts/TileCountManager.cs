using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TileCountManager
{
    public static IReadOnlyList<Tile> Tiles => _tiles;

    private static List<Tile> _tiles = new List<Tile>();

    public static void AddList(Tile tile)
    {
        _tiles.Add(tile);
    }
}
