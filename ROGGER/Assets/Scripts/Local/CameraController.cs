using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Player player;
    Transform target;
    [SerializeField] Vector3 offset;
    public float smoothSpeed = 12.5f;

    void Awake()
    {
        GameManager.Instance.OnPlayerJoined += HandleOnPlayerJoined;
    }

    private void HandleOnPlayerJoined(Player player)
    {
        this.player = player;
        transform.LookAt(player.transform);
        target = player.transform;
    }

    void Update()
    {
        Vector3 finalPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, finalPos, smoothSpeed * Time.deltaTime);
    }
}
