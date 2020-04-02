using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateBoardMovement : MonoBehaviour
{
    public bool falling;
    public float pressTime = 0.0f;
    public float moveSpeed;
    public float jumpHeight;
    public int addedForwardMomentum;
    public int addedJumpMomentum;

    public float turnRadius;
    //class will showcase basic movement properties
    //objects with this script should be able to move left and right, accelarate, and brake
    //objects with this class should also be able to jump and manuver in the air without flying into outerspace.
    public void Start()
	{

	}
    private void Accelarate()
    {
        //Player character Kicks the ground to boost their speed
        //in script this adds some speed to the player character so they can move faster

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressTime += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveSpeed += pressTime;
            pressTime = 0.0f;
        }

    }

    private void lean()
    {
        //player leans to manuver their motherboard left and right
        //in script this will make it so if the player presses the left button for example: 
        // the board will slowly but surely turn left.

    }

    private void hitTheBreaks()
    {
        //player stops the skateborad by slamming their foot on the ground
        //in script this will make it so momentum is stopped.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressTime += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            moveSpeed -= pressTime;
            pressTime = 0.0f;
        }

    }


    public void Update()
    {

    }
}
