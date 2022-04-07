using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecionavel : MonoBehaviour
{
    public Material original;
    public Material selecionado;
    public string texto;
    void Start()
    {
        GetComponent<MeshRenderer>().material = original;
    }

    public void AtivaSelecao()
    {
        GetComponent<MeshRenderer>().material = selecionado;
    }

    public void DesativaSelecao()
    {
        GetComponent<MeshRenderer>().material = original;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
