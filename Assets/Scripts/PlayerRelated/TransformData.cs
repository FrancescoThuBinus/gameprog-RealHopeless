using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTransformData", menuName = "Transform Data")]

public class TransformData : ScriptableObject
{

    public Vector2 position;
    public Vector2 playerPositionThen;
    public void ResetData()
    {
        position = Vector2.zero;
    }
}
