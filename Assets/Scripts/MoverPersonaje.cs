using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField] float puntos;
    [SerializeField] float vida;
    [SerializeField] float alturaSalto;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;
    [SerializeField] GameObject gameOver;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClip;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            audioSource.clip= audioClip[0];
            audioSource.Play();
            if (ComprobarSuelo.EsteEnElAire)
            {
                rigidbody.AddForce(Vector2.up * alturaSalto);
                
            }
        }
        
        if (rigidbody.velocity.y > 0.1f || rigidbody.velocity.y < -0.1f)
        {
            animator.SetBool("EsteEnElAire", true);
        }
        else
        {
            animator.SetBool("EsteEnElAire", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemigo")
        {

            GameManager.Instancia.Perder();

        }
        
    }
}
