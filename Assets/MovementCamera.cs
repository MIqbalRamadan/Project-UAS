using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        
    }
}
