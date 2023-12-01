using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public string playerTag = "Player";
    public float followSpeed = 0f;

    private Transform playerTransform;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("1");
        }
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();
            transform.position += direction * followSpeed * Time.deltaTime;
        }
    }
}