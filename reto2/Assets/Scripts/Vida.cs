using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida;
    public float maximoVida;
    public BarraVida barraVida;
    public GameObject gameOver; 

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;   
        barraVida.InicializarBarraDeVida(vida); 
    }



    public void TomarVida(float dano)
    {
        
        vida = vida - dano;
        barraVida.CambiarVidaActual(vida);
        Debug.Log("vida: " + vida);
        if(vida <= 0){
            //Destroy(gameObject);
            gameOver.SetActive(true);
        }
    }

    public void Curar(float curacion)
    {
        if((vida + curacion) > maximoVida)
        {
            vida = maximoVida;

        }else{
            vida = vida + curacion;
        }
        barraVida.CambiarVidaActual(vida);
    }
}
