using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IPointerClickHandler
{
    public TileData TileData => _data;
    public bool OnPlayer => _onPlayer;

    private TileData _data;

    private Tile[] _tiles;

    private bool _onPlayer = false;

    public void SetTileData(TileData data)
    {
        _data = data;
    }

    public void SetTiles()
    {
        _tiles = new Tile[4];
        for (int i = 0; i < 4; i++)// 隣接するタイルの最大値で回す
        {
            int x = 0;
            int y = 0;
            switch (i)
            {
                case 0:
                    x = 1;
                    break;
                case 1:
                    x = -1;
                    break;
                case 2:
                    y = 1;
                    break;
                case 3:
                    y = -1;
                    break;
            }
            Tile ?tile = TileCountManager.Tiles
                .Where(t => t.TileData.Width == _data.Width + x
                && t.TileData.Height == _data.Height + y) as Tile;
            if(tile)
            {
                _tiles[i] = tile;
            }
        }
    }

    public void SetStep(int count)
    {
        if (count < 1) return;
        _data.SetStepCount(count);
        foreach(var t in _tiles)
        {
            t.SetStep(count--);
        }
    }

    public void PlayerOnTile(bool flag)
    {
        _onPlayer = flag;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClickManager.OnClick(this);
    }
}
