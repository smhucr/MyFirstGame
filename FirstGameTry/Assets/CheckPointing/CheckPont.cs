using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPont : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Player;   
    private void Start()
    {
        int SpawnPoint = PlayerPrefs.GetInt("CheckPoint");
        Player.transform.position = spawnPoints[SpawnPoint].position;
    }
}
