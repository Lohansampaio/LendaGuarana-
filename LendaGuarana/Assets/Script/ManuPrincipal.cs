using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    
    public void Jogar()
    {

        SceneManager.LoadScene("Jogo");


    }
    public void SairDoJogo()
    {
        Debug.Log("Sair");
        Application.Quit();
    }
}
