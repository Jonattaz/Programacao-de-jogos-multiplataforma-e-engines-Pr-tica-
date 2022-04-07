using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    Selecionavel selecionado;
    public Text label;

    void Start()
    {
        label.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //cria raio a partir do mouse
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 10, new Color(250, 120, 10));

        //reposta da colisao
        RaycastHit hit;
        //testa a colisao do raio


        Selecionavel selecao = null;
        if(Physics.Raycast(raio, out hit, 10))
        {
            selecao = hit.transform.GetComponent<Selecionavel>();
        }        

        //ativa a selecao
        if(selecao)
        {
            selecao.AtivaSelecao();
            label.text = selecao.texto;
        }

        if(selecao != selecionado)
        {
            if(selecionado)
            {
                selecionado.DesativaSelecao();   
                label.text = "";
            }         
            selecionado = selecao;
        }

        //verifica se é clicável
        if(selecao && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Clicavel obj = selecao.GetComponent<Clicavel>();
            if(obj)
            { 
                obj.Ativar();
                label.text = "";
            }
            
        }    
        
    }
}
