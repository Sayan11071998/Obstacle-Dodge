using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Transform player;

    private Vector3 playerPosition;

    private void Awake() => gameObject.SetActive(false);
    private void Start() => playerPosition = player.transform.position;

    private void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    private void MoveToPlayer()
    {
        transform.position =
        Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
            Destroy(gameObject);
    }
}