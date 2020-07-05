using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class placarController : MonoBehaviour
{
    [SerializeField]
    string nome;
    [SerializeField]
    int pontos;
    [SerializeField]
    TMP_Text placar, tripulante;

    [SerializeField]
    GameObject final;

    private void Start()
    {
        tripulante.text = nome;
    }

    public void SetPlacar(int ptos)
    {
        pontos = pontos + ptos;
        placar.text = "PONTOS: "+pontos.ToString();

        if(pontos >= 40)
        {
            final.SetActive(true);
        }
    }
}
