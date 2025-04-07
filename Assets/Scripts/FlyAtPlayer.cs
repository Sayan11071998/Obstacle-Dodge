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
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}