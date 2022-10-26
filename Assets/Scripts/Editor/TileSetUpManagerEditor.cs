using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileSetUpManager))]
public class TileSetUpManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        TileSetUpManager setUpManager = target as TileSetUpManager;

        if (GUILayout.Button("SetUpTiles"))
        {
            setUpManager.SetTileDatas();
            Debug.Log("SetUpŠ®—¹");
        }
    }
}
