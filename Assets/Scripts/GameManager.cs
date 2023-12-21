using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public float tiempo;
    [SerializeField] int Puntos;
    [SerializeField] public int puntuacionActual, mejorPuntuacion;
    [SerializeField] GameObject Texto, Boton, Personaje, Fuego, Mosca;
    [SerializeField] TMP_Text texto;
    [SerializeField] MoverPersonaje controladorPersonaje;
    [SerializeField] bool Cronometro;
    [SerializeField] MoverMosca Enemigo;
    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Boton.SetActive(false);
        Texto.SetActive(false);
        mejorPuntuacion = PlayerPrefs.GetInt("mejorPuntuacion");
        
    }

    // Update is called once per frame
    void Update()
    {      
        if (Cronometro == true)
        {
            
            tiempo += Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
            Debug.Log(minutos + ":" + segundos);
            string textoTiempo = $"{minutos:D2} : {segundos:D2}";
            texto.text = textoTiempo;
        }
        
    }

    public void Perder()
    {
        Personaje.SetActive(false);
        Fuego.SetActive(false);
        Mosca.SetActive(false);
        Texto.SetActive(true);
        Boton.SetActive(true);
        Cronometro = false;
    }

    public void ReiniciarJuego()
    {
        Puntos = 0;
        Personaje.SetActive(true);
        Fuego.SetActive(true);
        Mosca.SetActive(true);
        Texto.SetActive(false);
        Boton.SetActive(false);
        tiempo = 0;
        Cronometro = true;
        Enemigo.ReiniciarEnemigo();
    }
    public void SumarPunto()
    {
        puntuacionActual += 1;
        if (puntuacionActual >= mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }

}

