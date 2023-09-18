using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Transform playerTransform;
    public Camera mainCamera;
        
    private class Gravity
    {
        public float groundDistance;
        public float gravity;
    }

    [Header("Settings")] 
    [SerializeReference] private Gravity gravity = new(); 
    
    [Header("State")]
    [SerializeField] private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckGround()
    {
        grounded = Physics.Raycast(playerTransform.position, Vector3.down, gravity.groundDistance);
    }

    void Fall()
    {

    }

    void Move()
    {
        
    }
}
