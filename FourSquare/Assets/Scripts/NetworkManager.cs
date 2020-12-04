﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        OnConnectedToServer();
    }

    private void OnConnectedToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Try Connect to server");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server");
        base.OnConnectedToMaster();

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 10;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;
        PhotonNetwork.JoinOrCreateRoom("Room big nuts", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a room");
        base.OnJoinedRoom();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("a player joined");
        base.OnPlayerEnteredRoom(newPlayer);
    }
}
