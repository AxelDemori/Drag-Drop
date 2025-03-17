using UnityEngine;

public class CameraEdge : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float edgeThreshold = 50f;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        if (mousePosition.x <= edgeThreshold)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (mousePosition.x >= Screen.width - edgeThreshold)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}