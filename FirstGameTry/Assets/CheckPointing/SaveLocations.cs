using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLocations : MonoBehaviour
{
    public int locationid;
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("CheckPoint", locationid);
        }
    }
}
