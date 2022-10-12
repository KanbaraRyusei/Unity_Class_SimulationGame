using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGanerator : MonoBehaviour
{
    [SerializeField]
    [Header("横")]
    int _width;

    [SerializeField]
    [Header("縦")]
    int _height;

    [SerializeField]
    [Header("間隔")]
    int _interval = 10;

    [SerializeField]
    [Header("横にずらす間隔")]
    int _widthInterval;

    [SerializeField]
    [Header("縦にずらす間隔")]
    int _heightInterval;

    [SerializeField]
    [Header("プレハブ")]
    GameObject _tilePrefab;

    public void SetTiles()
    {
        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _width; j++)
            {
                GameObject tile = Instantiate(_tilePrefab,
                    new Vector3(i * _interval + _heightInterval, j * _interval + _widthInterval,
                    0), transform.rotation);
                var t = tile.GetComponent<Tile>();
                t.SetTile(i, j);
                TileCountManager.AddList(t);
            }
        }
        Debug.Log("生成完了");
        TileSetting();
    }

    private void TileSetting()
    {
        foreach(var t in TileCountManager.Tiles)
        {
            t.SetTiles();
        }
    }
}
