using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Square
{
    [SerializeField] private Vector2 _center;
    [SerializeField] private Vector2 _size;

    public Vector2 Center => _center;
    public Vector2 Size => _size;

    public Vector2 LowerLeft => new Vector2(_center.x - _size.x / 2f, _center.y - _size.y / 2f);
    public Vector2 LowerRight => new Vector2(_center.x + _size.x / 2f, _center.y - _size.y / 2f);
    public Vector2 UpperLeft => new Vector2(_center.x - _size.x / 2f, _center.y + _size.y / 2f);
    public Vector2 UpperRight => new Vector2(_center.x + _size.x / 2f, _center.y + _size.y / 2f);

    public Square(Vector2 center, Vector2 size)
    {
        _center = center;
        _size = size;
    }

    public void DrawGizmo(Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawLine(LowerLeft, UpperLeft);
        Gizmos.DrawLine(UpperLeft, UpperRight);
        Gizmos.DrawLine(UpperRight, LowerRight);
        Gizmos.DrawLine(LowerRight, LowerLeft);
    }
}
