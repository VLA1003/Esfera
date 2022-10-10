using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMoneda : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;

    void Update()
    {
        transform.Rotate(0.0f, 0.0f, rotacionY * Time.deltaTime);
    }
}
