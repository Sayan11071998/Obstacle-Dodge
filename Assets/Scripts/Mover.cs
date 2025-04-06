using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private void Start()
    {
        PrintInstructions();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects");
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}