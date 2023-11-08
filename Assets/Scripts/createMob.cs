using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createMob : MonoBehaviour
{
    public GameObject tilePrefab;
    int numObjects = 0;
    void Start()
    {
        for (int i = 0; i < numObjects; i++)
        {
            Vector3 position = new Vector3(Random.Range(0, 100), Random.Range(0, 100), 0);

            Instantiate(tilePrefab, position, Quaternion.identity);
        }
    }
}
