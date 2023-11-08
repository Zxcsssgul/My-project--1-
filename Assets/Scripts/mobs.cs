using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CreateMobs;

public class mobs : MonoBehaviour
{
    public GameObject objectToSpawn;


    void Start()
    {
        int M = Random.Range(70, 100);
        int Objects = M;
        for (int i = 0; i < Objects; i++)
        {
            
            //zxczxc
            float x = Random.Range(0, 100);
            float y = Random.Range(0, 100);
             

            Vector2 pos = new Vector2(x, y);
            GameObject gm = Instantiate(objectToSpawn, pos, Quaternion.identity);
        }
    }


}
