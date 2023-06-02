using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NetworkController : MonoBehaviourPunCallbacks
{
    [Header("LOBBY")]
    InputField roomNameInput;

    [SerializeField]
    string tempRoomName;

    [Header("PLAYER")]
    public GameObject playerPUN;
    

    public GameObject spawnPlayer;

    private void Awake()
    {
        //player1PUN = spawnPlayer.GetComponent
    }

    void Start()
    {

        

        tempRoomName = "Pato" + Random.Range(8, 99);
        PhotonNetwork.ConnectUsingSettings();

    }

    //######## Minhas Funções ##################
    public void Login()
    {
        

        /*if (playerNameInput.text != "")
        {
            PhotonNetwork.NickName = playerNameInput.text;
        }
        else
        {
            PhotonNetwork.NickName = tempPlayerName;
        }

        loginPn.gameObject.SetActive(false);
        lobbyPn.gameObject.SetActive(true);
        roomNameInput.text = tempRoomName;*/
    }

    public void QuickSearch()
    {
        PhotonNetwork.JoinLobby();
    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions() { MaxPlayers = 2 };
        PhotonNetwork.JoinOrCreateRoom(roomNameInput.text, roomOptions, TypedLobby.Default);
    }

    //############# PUN Callbacks ##################
    public override void OnConnected()
    {
        Debug.LogWarning("############# LOGIN #############");
        Debug.LogWarning("OnConnected");
    }

    public override void OnConnectedToMaster()
    {
        Debug.LogWarning("OnConnectedToMaster");
        Debug.LogWarning("Server: " + PhotonNetwork.CloudRegion);
        Debug.LogWarning("Ping: " + PhotonNetwork.GetPing());
    }

    public override void OnJoinedLobby()
    {
        Debug.LogWarning("############# LOOBY #############");
        Debug.LogWarning("OnJoinedLobby");
        PhotonNetwork.JoinRandomRoom();
        
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(tempRoomName);
        Debug.Log("Failed to enter Room... Creating Room Now...");
    }

    public override void OnJoinedRoom()
    {
        Debug.LogWarning("OnJoinedRoom");
        Debug.LogWarning("Nome da Sala: " + PhotonNetwork.CurrentRoom.Name);
        Debug.LogWarning("Nome da Player: " + PhotonNetwork.NickName);
        Debug.LogWarning("Players Conectados: " + PhotonNetwork.CurrentRoom.PlayerCount);

        /*loginPn.gameObject.SetActive(false);
        lobbyPn.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(false);*/

        //Vector3 pos = new Vector3(Random.Range(-15, 15), playerPUN.transform.position.y, Random.Range(-15, 15));

       //PhotonNetwork.Instantiate(playerPUN.name, spawnPlayer.transform.position, playerPUN.transform.rotation, 0);

        


    }
}
