using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 1f;

    private Vector3 playerPosition;

    private void Start()
    {
        playerPosition = player.transform.position;
    }

    private void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
            Destroy(gameObject);
    }
}