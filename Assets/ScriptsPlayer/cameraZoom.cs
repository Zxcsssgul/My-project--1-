using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    
    public float zoom = 10F;


    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && zoom > 4)
        {
            zoom -= 1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && zoom < 15)
        {
            zoom += 1;
        }

        GetComponent<Camera>().orthographicSize = zoom;
        

      
               
       

    }
}

