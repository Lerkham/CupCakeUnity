using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour
{
    public static bool EsteEnElAire;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EsteEnElAire = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EsteEnElAire = false;
    }
}
