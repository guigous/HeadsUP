using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] GameObject[] avatar;
    public int playerId;


    private void Awake()
    {
        int personagemSelecionado = PlayerPrefs.GetInt(string.Format("Personagem{0}", playerId));

        avatar[personagemSelecionado].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
