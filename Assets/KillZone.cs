using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject redWinUI;
    public GameObject blueWinUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue")) 
        {        
            Destroy(other.gameObject);
            redWinUI.SetActive(true);
            //player.GetComponent<playercontroller>().enabled = false;
        }
        else if (other.CompareTag("Red")) 
        {
            Destroy(other.gameObject);
            blueWinUI.SetActive(true);
            //player.GetComponent<playercontroller>().enabled = false;
        }
    }
}
