using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int Tiempo, Puntos;
    [SerializeField] GameObject Texto, Boton, Personaje, Fuego, Mosca;
    bool Cronometro;
    [SerializeField] MoverMosca Enemigo;

    // Start is called before the first frame update
    void Start()
    {
        Boton.SetActive(false);
        Texto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { if (Cronometro == true)
        {

        }
        
    }

    void Perder()
    {
        Personaje.SetActive(false);
        Fuego.SetActive(false);
        Mosca.SetActive(false);
        Texto.SetActive(true);
        Boton.SetActive(true);
        Cronometro = false;
    }

    void ReiniciarJuego()
    {
        Puntos = 0;
        Personaje.SetActive(true);
        Fuego.SetActive(true);
        Mosca.SetActive(true);
        Texto.SetActive(false);
        Boton.SetActive(false);
        Tiempo = 0;
        Cronometro = true;
        Enemigo.ReiniciarEnemigo();
    }
}

