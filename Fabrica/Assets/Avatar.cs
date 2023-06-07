using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] GameObject[] avatar;
    public int playerId;
    public PhotonView photonview;


    private void Awake()
    {
        int personagemSelecionado = PlayerPrefs.GetInt(string.Format("Personagem{0}", playerId));

        if (photonview.IsMine && playerId == 1)
        {
            avatar[personagemSelecionado].SetActive(true);
        }
        
    }
           

    // Start is called before the first frame update
    void Start()
    {

        photonview = this.GetComponent<PhotonView>();
        Debug.LogWarning("Name: " + PhotonNetwork.NickName + " PhotonView: " + photonview.IsMine);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
