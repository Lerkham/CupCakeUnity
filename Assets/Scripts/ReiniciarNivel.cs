using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarNivel : MonoBehaviour
{
   public void Reiniciar()
    {
        SceneManager.LoadScene(0);
        GameManager.Instancia.ReiniciarJuego();
    }
    
       
    

}
