using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target = null;
    public Vector3 offset = Vector3.zero;
    public float pitch = 2.0f;
    public float zoomSpeed = 4.0f;
    public float minZoom = 5.0f;
    public float maxZoom = 15.0f;
    public float yawSpeed = 100.0f;
    public float _currentYaw = 0.0f;

    private float _currentZoom = 10.0f;

    void Update()
    {
        _currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        _currentZoom = Mathf.Clamp(_currentZoom, minZoom, maxZoom);

        _currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }

    void LateUpdate()
    {
        transform.position = target.position - offset * _currentZoom;

        transform.LookAt(target.position + Vector3.up * pitch);

        transform.RotateAround(target.position,Vector3.up,_currentYaw);
    }
}
