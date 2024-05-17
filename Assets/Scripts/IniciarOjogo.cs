using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarOjogo : MonoBehaviour
{
    
    string nomeCena;
    public string cenaAtual;

    void Start(){
        cenaAtual = nomeCena;
    }

    public void TrocarDeCena(){
        SceneManager.LoadScene(cenaAtual);
    }

}
