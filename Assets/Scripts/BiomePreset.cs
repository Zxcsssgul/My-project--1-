using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
[CreateAssetMenu(fileName = "Biome Preset", menuName = "New Biome Preset")]
public class BiomePreset : ScriptableObject
{
    public Sprite[] tiles = new Sprite[7];
   
        
    public float minHeight;
    public float minMoisture;
    public float minHeat;
    public Sprite GetTleSprite()
    {
        return tiles[Random.Range(0, tiles.Length)];
    }
    public bool MatchCondition(float height, float moisture, float heat)
    {
        return height >= minHeight && moisture >= minMoisture && heat >= minHeat;
    }
}