using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    private GameObject spawnedPlayerPrefab;

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        spawnedPlayerPrefab = PhotonNetwork.Instantiate("Prefabs/PlayerPrefab", transform.position, Quaternion.identity);
        
    }

    public override void OnLeftLobby()
    {
        base.OnLeftLobby();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }
}
