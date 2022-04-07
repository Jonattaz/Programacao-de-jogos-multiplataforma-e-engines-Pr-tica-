using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaClicavel : Clicavel
{
    public Ponte ponte;


    void Update()
    {
        if(!ponte.fechando)
            GetComponent<Selecionavel>().texto = "Clique para fechar";
        else
            GetComponent<Selecionavel>().texto = "Clique para abrir";

    }
    public override void Ativar()
    {
        ponte.fechando = !ponte.fechando;
    }
}
