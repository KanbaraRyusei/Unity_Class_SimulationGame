using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileGanerator))]
public class TileGaneratorEditor : Editor
{
    private TileGanerator _tileGanerator;

    private void OnEnable()
    {
        _tileGanerator = target as TileGanerator;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("SetTiles"))
        {
            _tileGanerator.SetTiles();
        }
    }
}
