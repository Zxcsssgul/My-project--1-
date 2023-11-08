using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using static Map;

public class PlayerController : MonoBehaviour
{
   
    private bool isMoving = false;
    private Vector3 targetPosition;
    private float speed = 0.5f;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (isMoving)
        {
            Move();
        }
        
        
    }
    private void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        isMoving = true;
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed = Time.deltaTime);
        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }
    

}
