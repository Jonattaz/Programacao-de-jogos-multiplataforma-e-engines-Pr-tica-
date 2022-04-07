using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponte : MonoBehaviour
{
    public Vector3 aberta;
    public Vector3 fechada;

    public bool fechando;
    public float velocidade;
    void Start()
    {
        fechando = false;
    }

    // Update is called once per frame
    void Update()
    {
        float step = velocidade * Time.deltaTime;
        
        if(fechando)
        {
            transform.position = Vector3.MoveTowards(transform.position, fechada, step);
        }
        else{
            transform.position = Vector3.Lerp(transform.position, aberta, 0.005f);
        }
    }
}
