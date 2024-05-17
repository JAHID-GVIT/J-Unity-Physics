//Group-6 PPT
//22BCG10089
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float bounceForce = 10f;

    [Range(0f, 1f)]
    public float elasticity = 0.5f;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Vector3 bounceDirection = Vector3.up;

            float adjustedBounceForce = Mathf.Clamp(bounceForce * elasticity, 0f, 20f);

            GetComponent<Rigidbody>().AddForce(bounceDirection * adjustedBounceForce, ForceMode.Impulse);
        }
    }
}
