using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMosca : MonoBehaviour
{
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }
}
