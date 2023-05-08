using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    // How far away can the character go in each direction before the camera follows him?
    public float boundX = 0f;
    public float boundY = 0f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        //check if we're on the bounds of the x-axis
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundX || deltaX < -boundX)
        {
            if (transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }
        //check if we're on the bounds of the y-axis
        float deltaY = lookAt.position.y - transform.position.y;
        if(deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }
        //moving the camera
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}

