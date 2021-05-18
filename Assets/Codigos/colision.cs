using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    // Start is called before the first frame update
    public int numeroBonus = 0;
    public Text puntajeBonus;
    public Image barraVida;
    public float vida;
    void Start()
    {
        puntajeBonus.text = "0";
        vida = 100;
        barraVida.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bonusTag")
        {
            //Debug.Log("Colisionó con el bonus");
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            numeroBonus  += 1;
            Debug.Log(numeroBonus);
            puntajeBonus.text = numeroBonus.ToString();
        }

        if(other.tag == "obstaculoTag")
        {
            vida -= 10;
            barraVida.fillAmount = vida/100;
            if(vida <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
