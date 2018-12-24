using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    [SerializeField] Vector3 offset;
    public float smoothSpeed = 12.5f;

    void Start()
    {
    }

    void Update()
    {
        Vector3 finalPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);
    }
}
