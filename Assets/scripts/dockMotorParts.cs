using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using System.Linq;
using System;
using UnityEngine.UI;
using TMPro;

public class dockMotorParts : MonoBehaviour
{
[SerializeField]
    Dockable[] m_dockable;

    [SerializeField]
    DockPosition dockPosition;

    [SerializeField]
    string objName;

    [SerializeField]
    GameObject[] desligar;

    [SerializeField]
    GameObject[] ligar;

    [SerializeField]
    GameObject instrucoes, check;

    [SerializeField]
    placarController p_controller;


    private void Start()
    {
        dockPosition = gameObject.GetComponent<DockPosition>();
        
    }
    void HideMeshIfDocked()
    {
        Debug.Log("método acionado com colisão...");

        switch (objName)
        {
            case "eixo":
                Debug.Log("Acionar game objects e desligar collider");
                LigarObjetos();
                DesligarObjetos();
                break;

            case "correia":
                Debug.Log("Acionar game objects e desligar collider");
                LigarObjetos();
                DesligarObjetos();
                break;

            case "engrenagem":
                Debug.Log("Acionar game objects e desligar collider");
                LigarObjetos();
                DesligarObjetos();
                break;

            case "polia":
                Debug.Log("Acionar game objects e desligar collider");
                LigarObjetos();
                DesligarObjetos();
                break;

        }
    }




    void OnTriggerEnter(Collider collider)
    {
        //dockPosition = collider.gameObject.GetComponent<DockPosition>();
       
        if (dockPosition != null && collider.gameObject.name == objName)
        {

            //objName = collider.gameObject.name;
            Debug.Log($"{collider.gameObject.name} collided with {dockPosition.name} no meu script");
            Debug.Log("Funcionou para o "+ objName);
            HideMeshIfDocked();
        }
    }



    void LigarObjetos()
    {
        for (int i = 0; i<ligar.Length; i++)
        {
            ligar[i].GetComponent<MeshRenderer>().enabled = true;
        }

        int ptos = 10;

        p_controller.SetPlacar(ptos);
    }

    void DesligarObjetos()
    {
        for (int i = 0; i < desligar.Length; i++)
        {
            desligar[i].gameObject.SetActive(false);
        }

        instrucoes.gameObject.SetActive(false);
        check.gameObject.SetActive(true);
    }
}
