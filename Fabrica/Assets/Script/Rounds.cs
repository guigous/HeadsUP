using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rounds : MonoBehaviour
{

    public Sprite cinza;
    public Sprite laranja;

    public Image ponto1Player1;
    public Image ponto2Player1;
    public Image ponto1Player2;
    public Image ponto2Player2;

    public GameObject player1Wins;
    public GameObject player2Wins;

    public GameObject blackPanel;


    private int pontosPlayer1 = 0; //deve aumentar quando player 1 pisar no player 2
    private int pontosPlayer2 = 0;

    void Update()
    {
        if (pontosPlayer1 == 1)
        {
            ponto1Player1.sprite = laranja;
        }
        else if (pontosPlayer1 == 2)
        {
            ponto2Player1.sprite = laranja;
        }

        if (pontosPlayer2 == 1)
        {
            ponto1Player2.sprite = laranja;
        }
        else if (pontosPlayer2 == 2)
        {
            ponto2Player2.sprite = laranja;
        }
    }

    public void Player1GanhouRound()
    {
        pontosPlayer1++;

        if (pontosPlayer1 == 2)
        {
            // Player 1 ganhou o jogo!
            player1Wins.SetActive(true);
            blackPanel.SetActive(true);
            
        }
    }

    public void Player2GanhouRound()
    {
        pontosPlayer2++;

        if (pontosPlayer2 == 2)
        {
            // Player 2 ganhou o jogo!
            player2Wins.SetActive(true);
            blackPanel.SetActive(true);
            
        }
    }
}