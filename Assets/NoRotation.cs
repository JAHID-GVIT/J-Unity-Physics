using UnityEngine;

public class PreventRotation : MonoBehaviour
{
    public bool preventRotationX = false;
    public bool preventRotationY = false;
    public bool preventRotationZ = false;

    void Update()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;

        if (preventRotationX)
            currentRotation.x = 0f;

        if (preventRotationY)
            currentRotation.y = 0f;

        if (preventRotationZ)
            currentRotation.z = 0f;

        transform.rotation = Quaternion.Euler(currentRotation);
    }
}

