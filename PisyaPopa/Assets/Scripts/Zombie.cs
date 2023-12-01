using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public string playerTag = "Player";
    public float followSpeed = 5;

    private bool facingRight = true;

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
    // lox pidrs
    public void FixedUpdate()
    {
        if (playerTransform != null)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();
            transform.position += direction * followSpeed * Time.deltaTime;
        }
       
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}