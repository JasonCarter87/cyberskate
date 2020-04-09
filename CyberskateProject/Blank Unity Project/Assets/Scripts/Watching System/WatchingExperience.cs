using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchingExperience : MonoBehaviour
{

    Sight sight;

    public float playerExp;

    // Start is called before the first frame update
    void Start()
    {
        sight = GameObject.FindGameObjectWithTag("GameController").GetComponent<Sight>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sight.playerInSight == true) {
            playerExp += 1;
        }
    }
}
