using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensivity = 5f;
    private float xRotation = 0f;
    public Rigidbody rb;
    public GameObject player;

    private void Start()
    {/*
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;*/
    }
    private void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensivity;
        if (player.transform.localPosition.y < 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(0, 5, 0);
            }
        }
        mouseY = -mouseY;
        xRotation += mouseY;
   
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation,0, 0); // Rotation 4 boyutta olduğu için böyle bir fonksiyon kullandık
        player.transform.Rotate(Vector3.up * mouseX );

    }
}
