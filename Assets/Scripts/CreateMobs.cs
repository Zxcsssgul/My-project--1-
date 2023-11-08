using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreateMob", menuName = "mobs")]

public class CreateMobs : ScriptableObject
{
    public Sprite[] tiles = new Sprite[3];

    public Sprite GetTleSprite()
    {
        return tiles[Random.Range(0, tiles.Length)];
    }


}
