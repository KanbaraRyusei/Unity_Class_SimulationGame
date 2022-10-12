using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGanerator : MonoBehaviour
{
    [SerializeField]
    [Header("��")]
    int _width;

    [SerializeField]
    [Header("�c")]
    int _height;

    [SerializeField]
    [Header("�Ԋu")]
    int _interval = 10;

    [SerializeField]
    [Header("���ɂ��炷�Ԋu")]
    int _widthInterval;

    [SerializeField]
    [Header("�c�ɂ��炷�Ԋu")]
    int _heightInterval;

    [SerializeField]
    [Header("�v���n�u")]
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
        Debug.Log("��������");
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
