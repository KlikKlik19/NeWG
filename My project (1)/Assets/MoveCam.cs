using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{

    public float sens;
    public Transform playeBody;
    float xRotation = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*sens*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*sens*Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playeBody.Rotate(Vector3.up* mouseX);
        
    }
}
