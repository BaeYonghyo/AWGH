
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{
    public Transform target;
    public float targetY = 0;

    public float xRotMax = 0;
    public float rotSpeed = 0;
    public float scrollSpeed = 0;

    public float distance = 0;
    public float minDistance = 0;
    public float maxDistance = 0;

    private float xRot;
    private float yRot;
    private Vector3 targetPos;
    private Vector3 dir;

    private void Update()
    {
        xRot += Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
        yRot += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        distance += -Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime;

        xRot = Mathf.Clamp(xRot, -xRotMax, xRotMax);
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

        targetPos = target.position + Vector3.up * targetY;

        dir = Quaternion.Euler(-xRot, yRot, 0f) * Vector3.forward;
        transform.position = targetPos + dir * -distance;
    }

    private void LateUpdate()
    {
        transform.LookAt(targetPos);
    }
}