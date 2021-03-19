using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneData", menuName = "Data/SceneData")]
public class SceneDataScriptableObject : ScriptableObject
{
    // Player Data
    [Header("Player Data")]
    public Vector3 playerPosition;
    public int playerHealth;
}
