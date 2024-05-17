using UnityEngine;

public class CubeLauncher : MonoBehaviour
{
    public Vector3 launchVelocity;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = launchVelocity;
        }
    }
}