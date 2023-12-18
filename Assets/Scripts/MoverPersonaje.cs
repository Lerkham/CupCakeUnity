using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] float vida = 10;
    [SerializeField] float puntos = 0;
    [SerializeField] GameObject gameOver;
    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Fuego")
        {
            vida -= 10;
            if (vida <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
                gameOver.SetActive(true);
            }
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "Mosca")
        {
            vida -= 10;
            if (vida <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
                gameOver.SetActive(true);
            }
            Destroy(collision.gameObject);
        }
    }
}
