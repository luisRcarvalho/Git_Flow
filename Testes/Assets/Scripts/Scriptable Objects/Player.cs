using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vilão minhaclasse;
    void Start()
    {
        minhaclasse.mostrainfos();
        //Debug.Log(minhaclasse.nome + " " + minhaclasse.classe + " " + minhaclasse.raça + " " + minhaclasse.vida);
    }
    void Update()
    {
        
    }

}
