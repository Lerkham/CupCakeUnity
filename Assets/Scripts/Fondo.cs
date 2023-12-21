using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    [SerializeField] Vector2 velocidad;
    [SerializeField] Material material;
    [SerializeField] Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offset = velocidad * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
