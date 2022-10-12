using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColisionMoneda : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaVictoria;

    [SerializeField]
    TextMeshProUGUI tiempoTotal;

    float tiempoPartida = 0.0f;
    int numeroMonedas = 0;
    bool estaJugando = true;

    public AudioClip sonidoMoneda;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoPartida = tiempoPartida + Time.deltaTime;
        }

        if (numeroMonedas == 7)
        {
            pantallaVictoria.SetActive(true);
            estaJugando = false;
            tiempoTotal.text = tiempoPartida.ToString();
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coin")
        {
            AudioSource.PlayClipAtPoint(sonidoMoneda, transform.position);
            other.gameObject.SetActive(false);
            numeroMonedas = numeroMonedas + 1;
        }
    }
}
