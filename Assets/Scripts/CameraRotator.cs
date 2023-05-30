using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 2f;

    private const float RotationClamp = 30f;

    private float mouseX;
    private float mouseY;

    private void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseX = Mathf.Clamp(mouseX, -RotationClamp, RotationClamp);
        mouseY = Mathf.Clamp(mouseY, -RotationClamp, RotationClamp);

        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        transform.rotation = rotation;
    }
}
