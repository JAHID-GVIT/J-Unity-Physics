using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectoroperations : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;

    void Start()
    {

    }

    void Update()
    {
        if (Object1 != null && Object2 != null)
        {
            Vector3 P1 = Object1.transform.position;
            Vector3 P2 = Object2.transform.position;

            Vector3 P3 = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
            {
                P3 = P1 + P2;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                P3 = P1 - P2;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                float dotProduct = Vector3.Dot(P1, P2);
                Debug.Log(dotProduct);
            }
            else if (Input.GetKey(KeyCode.X))
            {
                P3 = Vector3.Cross(P1, P2);
            }
            transform.position = P3;
        }
    }
}