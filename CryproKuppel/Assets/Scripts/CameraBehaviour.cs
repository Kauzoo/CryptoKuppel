using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Camera camera;
    private Transform cam_transform;

    [Header("Camera Settings")] public float xRotationSensitivity;
    public float yRotationSensitivity;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cam_transform = camera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

    void GetInput()
    {
    }

    void Fly()
    {
        var vert = Input.GetAxis("Vertical");
        var hor = Input.GetAxis("Horizontal");
        var mouseY = Input.GetAxis("Mouse Y");
        var mouseX = Input.GetAxis("Mouse X");
        var up = Input.GetKey(KeyCode.Space);
        var down = Input.GetKey(KeyCode.LeftShift);

        if (Input.GetKey(KeyCode.Mouse1))
        {
            cam_transform.Rotate(Vector3.up, mouseX * xRotationSensitivity, Space.Self);
            cam_transform.Rotate(Vector3.right, mouseY * yRotationSensitivity, Space.Self);
        }
        
        cam_transform.Translate(moveSpeed * vert * cam_transform.forward);
        cam_transform.Translate(moveSpeed * hor * cam_transform.right);

        if (Input.GetKey(KeyCode.Space))
        {
            cam_transform.Translate(cam_transform.up);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cam_transform.Translate(cam_transform.up * -1);
        }
    }
}