using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    public bool playerInSight;

    private List<GameObject> players;

    void Start()
    {
        players = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player")); 
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerStay(Collider other)
    {
        if (players.Contains(other.gameObject))
        {
            playerInSight = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (players.Contains(other.gameObject))
            playerInSight = false;
    }
}
