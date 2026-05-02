using UnityEngine;

public class SimpleXRKeyboardMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform cameraTransform;

    void Update()
    {
        if (cameraTransform == null) return;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        Vector3 move = (forward.normalized * z + right.normalized * x) * moveSpeed * Time.deltaTime;
        transform.position += move;
    }
}