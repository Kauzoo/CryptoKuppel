using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 4.0f;
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private float minTurnAngle = -90.0f;
    [SerializeField] private float maxTurnAngle = 90.0f;
    private float rotX;

    [SerializeReference] private Camera cam;
    private Transform cam_transform; 
    
    // Start is called before the first frame update
    void Start()
    {
        cam_transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MouseAiming();
        KeyboardMovement();
        // transform.position = cam_transform.position;
        // transform.rotation = cam_transform.rotation;
    }

    void MouseAiming()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        // rotate the camera
        cam_transform.eulerAngles = new Vector3(-rotX, cam_transform.eulerAngles.y + y, 0);
    }
    
    void KeyboardMovement ()
    {
        Vector3 dir = new Vector3(0, 0, 0);
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        cam_transform.Translate( moveSpeed * Time.deltaTime * dir);
    }
}
