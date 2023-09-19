using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kubrick : MonoBehaviour
{
    public Transform cam;
    public float yVelocity;
    public Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = cam.position;
        cam.position = new Vector3(pos.x, yVelocity, pos.z);
    }
}
