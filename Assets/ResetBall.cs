using UnityEngine;

public class ResetBall : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = rb.position;
        startRotation = rb.rotation;
    }

    public void ResetPosition()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        rb.position = startPosition;
        rb.rotation = startRotation;
    }
}