using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEsfera : MonoBehaviour
{
    Rigidbody body;
    Vector3 direction;

    [SerializeField]
    float velocidadJugador = 2.0f;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = -Input.GetAxis("Horizontal") * Time.deltaTime * velocidadJugador;
        direction.z = -Input.GetAxis("Vertical") * Time.deltaTime * velocidadJugador;
    }

    private void FixedUpdate()
    {
        body.AddForce(direction, ForceMode.Impulse);
    }
}
