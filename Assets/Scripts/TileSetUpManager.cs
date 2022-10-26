using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TileSetUpManager : MonoBehaviour
{
    public void SetTileDatas()
    {
        var tiles = FindObjectsOfType<Tile>();
        Debug.Log(tiles.Length);
        for (int i = 0; i < tiles.Length; i++)
        {
            if(tiles[i].TryGetComponent(out TileData tileData))
            {
                tiles[i].SetTileData(tileData);
            }
            else
            {
                var data =  tiles[i].gameObject.AddComponent<TileData>();
                tiles[i].SetTileData(data);
            }
        }
        List<float> oldX = new List<float>();
        List<float> oldZ = new List<float>();
        for (int i = 0; i < tiles.Length; i++)
        {
            if (i == 0)
            {
                oldX.Add(tiles[i].gameObject.transform.position.x);
                oldZ.Add(tiles[i].gameObject.transform.position.z);
                continue;
            }
            float tilePosX = tiles[i].gameObject.transform.position.x;
            float tilePosZ = tiles[i].gameObject.transform.position.z;
            if(!oldX.Contains(tilePosX))
            {
                oldX.Add(tilePosX);
            }
            if (!oldZ.Contains(tilePosZ))
            {
                oldZ.Add(tilePosZ);
            }
        }
        oldX.OrderBy(x => x);
        oldZ.OrderByDescending(x => x);
        Debug.Log(oldX.Count);
        Debug.Log(oldZ.Count);
        for (int i = 0; i < oldZ.Count; i++)
        {
            for (int j = 0; j < tiles.Length; j++)
            {
                if(oldZ[i] == tiles[j].gameObject.transform.position.z)
                {
                    tiles[j].TileData.SetHeight(i);
                }
            }
        }
        for(int i = 0; i < oldX.Count; i++)
        {
            for(int j = 0; j < tiles.Length; j++)
            {
                if(tiles[j].gameObject.transform.position.x == oldX[i])
                {
                    tiles[j].TileData.SetWidth(i);
                }
            }
        }
    }
}
