using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{
    Camera cam;
    Rigidbody rb;

    public float lerpValue=4;
    public float minY=1, maxY;
    public float minX, maxX;
    public float speed=4;

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
        rb.velocity= Vector3.forward * speed * Time.deltaTime;
       

    }

    public void Movement()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;


        Vector3 moveVec = cam.ScreenToWorldPoint(mousePos);
        float x = transform.localScale.x;
        moveVec.z = transform.localScale.z;
        moveVec.y *= 2f;
        moveVec.y = Mathf.Clamp(moveVec.y,minY,maxY);
        x = 10/moveVec.y;
       
        moveVec.x = Mathf.Clamp(x,minX,maxX);


       

        transform.localScale = Vector3.Lerp(transform.localScale, moveVec, lerpValue);
        GhostJelly.instance.ChangeScaleOfGhost(moveVec);

    }

}
