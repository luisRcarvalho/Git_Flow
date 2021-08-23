using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POOTeste : MonoBehaviour
{
    VilãoClass monstro = new VilãoClass();
    VilãoClass monstro2 = new VilãoClass();
    private void Start()
    {
        monstro.nome = "Kevin";
        monstro.classe = "Guerreiro";
        monstro.raça = "Demonio";
        monstro.vida = 50;
        monstro.mana = 50;
        monstro.poder = 100;

        monstro2.nome = "Rafael";
        monstro2.classe = "Arqueiro";
        monstro2.raça = "Anjo";
        monstro2.vida = 77;
        monstro2.mana = 50;
        monstro2.poder = 100;

        Debug.Log(this.monstro.nome + " " + this.monstro.classe + " " + " " + this.monstro.raça + " " + this.monstro.vida +
            " " + this.monstro2.nome + " " + this.monstro2.classe + " " + " " + this.monstro2.raça + " " + this.monstro2.vida);
    }

}
