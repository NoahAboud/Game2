using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject redWinUI;
    public GameObject blueWinUI;
    public GameObject red;
    public GameObject blue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue")) 
        {        
            Destroy(other.gameObject);
            redWinUI.SetActive(true);
            red.GetComponent<Player2Movement>().enabled = false;
            blue.GetComponent<Character>().enabled = false;
        }
        else if (other.CompareTag("Red")) 
        {
            Destroy(other.gameObject);
            blueWinUI.SetActive(true);
            red.GetComponent<Player2Movement>().enabled = false;
            blue.GetComponent<Character>().enabled = false;
        }
    }
}
