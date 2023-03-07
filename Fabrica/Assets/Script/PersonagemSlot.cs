using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonagemSlot : MonoBehaviour
{
    [SerializeField] private Sprite[] avatares;
    [SerializeField] private Image avatarImagem;
    [SerializeField] private int avatarIndice;
    [SerializeField] private int indiceSlot;



    public static bool[] escolhido;
    private int ultimoAvatarIndice;
    private bool primeiraEscolha = true;

    private void Start()
    {
        escolhido = new bool[avatares.Length];
    }


    public void MudarPersonagem(int direcao)
    {
        if (ChecarAvatarDisponivel())
        {
            avatarIndice += direcao;


            if(avatarIndice < 0)
            {
                avatarIndice = avatares.Length - 1;
            }

            if (!escolhido[avatarIndice])
            {
                avatarImagem.sprite = avatares[avatarIndice];
                escolhido[avatarIndice] = true;

                PlayerPrefs.SetInt (string.Format("Personagem{0}", indiceSlot), avatarIndice);
            }

            if(primeiraEscolha)
            {
                primeiraEscolha = false;
            }
            else
            {
                escolhido[ultimoAvatarIndice] = false;
            }

            ultimoAvatarIndice = avatarIndice;
        }

        else
        {
            MudarPersonagem(direcao);
        }
    }

    public bool ChecarAvatarDisponivel()
    {
        for (int i = 0; i < escolhido.Length; i++)
        {
            if (!escolhido[i])
            {
                return true;
            }
        }
        return false;
    }
}
