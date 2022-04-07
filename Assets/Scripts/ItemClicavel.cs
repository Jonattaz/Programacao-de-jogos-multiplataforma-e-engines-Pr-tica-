using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClicavel : Clicavel
{
    public GameObject arma;
    void Start()
    {
        
    }

    public override void Ativar()
    {
        arma.SetActive(true);
        Destroy(gameObject);
    }
}
