using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 2f;

    private float mouseX;
    private float mouseY;

    private void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -80f, 80f);

        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        transform.rotation = rotation;
    }
}
