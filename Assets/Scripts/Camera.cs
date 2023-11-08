using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public sealed class CameraControler : MonoBehaviour
{
    public float movementSpeed;
    public float movementTime;

    [SerializeField]
    public float leftBorder;
    [SerializeField]
    public float RightBorder;
    [SerializeField]
    public float UpperBorder;
    [SerializeField]
    public float DownBorder;
    [SerializeField]
    public float zsBorder;
    [SerializeField]
    public float ZBorder;

    public Vector3 newPosition;
    //newPosition = 
    public Vector3 dragCurrentPosition;
    public Vector3 dragStartPosition;

    private void Start()
    {
        newPosition = transform.position;
    }
    private void Update()
    {
        HanfleMovementInput();
        HandleMouseInput();

        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftBorder,RightBorder),
            Mathf.Clamp(transform.position.y, DownBorder,UpperBorder),
            Mathf.Clamp(transform.position.z, zsBorder, ZBorder)
            );
    }
    public void HandleMouseInput() 
    { 
        if (Input.GetMouseButtonDown(1))
        {
            Plane plane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;
            if (plane.Raycast(ray, out entry))
            {
                dragStartPosition = ray.GetPoint(entry);
            }
        }

        if (Input.GetMouseButton(1))
        {
            Plane plane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;
            if (plane.Raycast(ray, out entry))
            {
                dragCurrentPosition = ray.GetPoint(entry);

                newPosition = transform.position + dragStartPosition - dragCurrentPosition;
            }
        }
    }
   
    public void HanfleMovementInput()
    {
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    newPosition += (transform.forward * movementSpeed);
        //}
        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    newPosition += (transform.forward * -movementSpeed);
        //}
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    newPosition += (transform.right * movementSpeed);
        //}
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    newPosition += (transform.right * -movementSpeed);
        //}

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
    }
}

