using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vilão", menuName = "Vilão/vilão")]
public class Vilão : ScriptableObject
{
    public string nome, classe, raça;
    public int vida, mana, poder;
    void Start()
    {
        
    }

    public void mostrainfos()
    {
        Debug.Log(nome + " " + classe + " " + raça + " " + vida + " " + mana + " " + poder);
    }
}
