using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 2f;

    private MeshRenderer myMeshRenderer;
    private Rigidbody myRigidBody;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    private void Update()
    {
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}