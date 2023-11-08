using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Principal;
using System.Threading;
using static Map;
using UnityEngine;



public class CreateCastl : MonoBehaviour
{
    public GameObject objectToSpawn;

    
void Start()
    {
        
        //zxczxc
        float x = Random.Range(0, 100);
        float y = Random.Range(0, 100);

      
        Vector2 pos = new Vector2(x, y);
        GameObject gm = Instantiate(objectToSpawn, pos, Quaternion.identity);

    }
       

    }
   


