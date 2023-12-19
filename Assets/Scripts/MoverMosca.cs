using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMosca : MonoBehaviour
{
    [SerializeField] float velocidad;
    Camera camara;
    Vector2 PInicial, PMinima;
    
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        PMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        PInicial = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);

        if (transform.position.x < PMinima.x-5) 
        {
            transform.position = PInicial;
            velocidad++;
        }
    }
    public void ReiniciarEnemigo()
    {
        
    }

}
