using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControls : MonoBehaviour
{
    public float speed = 1;
    public float rotationSpeed = 1;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed;
        transform.position += movement * Time.deltaTime;

        Vector3 lastPos = transform.position;

        Vector3 wantedPos = transform.position + movement * Time.deltaTime;

        float anguloReal = RealAngle(lastPos, wantedPos);

        Quaternion currentRotation = transform.rotation;
        Quaternion newRotation = Quaternion.Euler(0, anguloReal, 0);
        Quaternion finalRotation = Quaternion.Slerp(currentRotation, newRotation, rotationSpeed * Time.deltaTime);

        if (Mathf.Abs(horizontal) > 0.001f || Mathf.Abs(vertical) > 0.001f)
        {
            transform.rotation = finalRotation;
        }
    }

    float RealAngle(Vector3 from, Vector3 to)
    {
        Vector3 right = Vector3.right;
        Vector3 dir = to - from;

        float angle = Vector3.Angle(right, dir);
        Vector3 cross = Vector3.Cross(right, dir);

        if(cross.y < 0)
        {
            angle = 360 - angle;
        }

        return angle;
    }
}
