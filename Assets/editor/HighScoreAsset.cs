using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HighScoreAsset : ScriptableObject
{
    [MenuItem("Assets/Create/Highscore")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<Highscore>();
    }
}
