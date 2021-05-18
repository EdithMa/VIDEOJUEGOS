using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverConPiso : MonoBehaviour
{
    // Start is called before the first frame update
    Collider objChoca;
    string chocaNombre;
    string ultimoChocaNombre;
    Vector3 chocaPosicion;
    Vector3 ultimoChocaPosicion;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(objChoca != null)
        {
            chocaNombre = objChoca.name;
            chocaPosicion = objChoca.transform.position;
            if(chocaPosicion != ultimoChocaPosicion && chocaNombre == ultimoChocaNombre)
            {
                this.transform.position += chocaPosicion - ultimoChocaPosicion;
            }
            ultimoChocaNombre = chocaNombre;
            ultimoChocaPosicion = chocaPosicion;
        }
        else
        {
            ultimoChocaNombre = null;
            ultimoChocaPosicion = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "plataformaMovilTag")
        {
           // Debug.Log("colisionó");
           objChoca = other;
        }
        else
        {
            objChoca = null;
        }
    }
}
