using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public Text textoDePontuacao;
    
    public AudioSource somDoGol;

    public int setJogador1;
    public int setJogador2;
    public Text textoDePontuacaoSetJogador2;
    public Text textoDePontuacaoSetJogador1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Saiu do jogo");
        }

    }

    public void AumentarPontuacaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
        AtualizarTextoDePontuacao();
    }
    public void AumentarPontuacaoDoJogador2()
    {
        pontuacaoDoJogador2 += 1;
        AtualizarTextoDePontuacao();
    }

    public void AtualizarTextoDePontuacao()
    {
        
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
        //textoDePontuacaoSets.text = "Sets" + setJogador1 + " X " + setJogador2 + "Sets";

        if (pontuacaoDoJogador1 == 21)
        {
            setJogador1 += 1;
            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
            textoDePontuacaoSetJogador1.text = "Sets: " + setJogador1 + " X ";

        }
        else if (pontuacaoDoJogador2 == 21)
        {
            setJogador2 += 1;
            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
            textoDePontuacaoSetJogador2.text = "" + setJogador2;
        }

        else if(setJogador1 == 2)
        {
            /*setJogador1 == 0;
            setJogador2 == 0;
            pontuacaoDoJogador1 == 0;
            pontuacaoDoJogador2 == 0;*/
            textoDePontuacao.text = "O Jogador 1 venceu!";
        }

        else if (setJogador2 == 2)
        {
            /*setJogador1 == 0;
            setJogador2 == 0;
            pontuacaoDoJogador1 == 0;
            pontuacaoDoJogador2 == 0;*/
            textoDePontuacao.text = "O Jogador 2 venceu!";
        }

        somDoGol.Play(); //inclusão do som
    }
    /*
    public void AumentarsetJogador1()
    {
        if(setJogador1 == 10)
        {
            setJogador1 += 1;
            AtualizarTextoDePontuacaoSets();
            pontuacaoDoJogador1 == 0;
            pontuacaoDoJogador2 == 0;
        }
    }

    public void AumentarsetJogador2()
    {
        if (setJogador2 == 10)
        {
            setJogador2 += 1;
            AtualizarTextoDePontuacaoSets();
            pontuacaoDoJogador1 == 0;
            pontuacaoDoJogador2 == 0;
        }
    }
    */

    /*public void AtualizarTextoDePontuacaoSets()
    {
        textoDePontuacaoSets.text = "Sets" + setJogador1 + " X " + setJogador2 + "Sets";
  
        somDoGol.Play(); //inclusão do som
    }*/
}
