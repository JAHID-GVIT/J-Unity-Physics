using UnityEngine;

public class LinearMotion : MonoBehaviour
{
    public Vector3 direction = Vector3.right;
    public float speed = 5f;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
