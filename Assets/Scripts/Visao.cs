using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{
    Transform cabeca;
    public float sensibilidade;
    void Start()
    {
        cabeca = GameObject.Find("Cabeca").transform;

         Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float rotY = Input.GetAxis("Mouse X") * sensibilidade;
        transform.Rotate(0,rotY,0);

        float rotX = Input.GetAxis("Mouse Y") * sensibilidade;
        //print(rotX);
        cabeca.Rotate(-rotX, 0, 0);
        //travar a cabeca
        //
        //float maxX = cabeca.eulerAngles.x;
        //print(cabeca.eulerAngles.x-360);
    }
}
