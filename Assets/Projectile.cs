using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 150f;

    void Awake()
    {
        Destroy(gameObject, life);
    }
}