using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateBoardMovement : MonoBehaviour
{
    Rigidbody rb;
    public bool falling;
    public float pressTime = 0.0f;
    public float moveSpeed;
    public float multiplyer = 0;
    public float jumpHeight;
    public float RotateSpeed = 30f;
    public int addedForwardMomentum;
    public int addedJumpMomentum;

    //for forward direction alteration
    private Vector3 targetDirection;

    //class will showcase basic movement properties
    //objects with this script should be able to move left and right, accelarate, and brake
    //objects with this class should also be able to jump and manuver in the air without flying into outerspace.
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 10.0f;
    }
    /* commented code is what's left over from the previous version of movement
    private void Accelarate()
    {
        //Player character Kicks the ground to boost their moveSpeed
        //in script this adds some moveSpeed to the player character so they can move faster
        pressTime += Time.deltaTime;
        multiplyer += pressTime*2;


    }

    private void lean()
    {
        //player leans to manuver their motherboard left
        //in script this will make it so if the player presses the left button for example: 
        // the board will slowly but surely turn left.
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * RotateSpeed, Space.World);
        targetDirection = new Vector3(x: horizontalMove, y: 0.0f, z: 0.0f);
        if(targetDirection != Vector3.zero)
        {

        }
    }

    private void hitTheBreaks()
    {
        //player stops the skateborad by slamming their foot on the ground
        //in script this will make it so momentum is stopped.
        pressTime += Time.deltaTime;
        multiplyer -= pressTime;

    }


    public void Update()
    {
        //makes sure that movement moveSpeed does not fall below zero
        if (multiplyer < 0)
        {
            multiplyer = 0;
        }
        else
        {

        }
        
        if (Input.GetKey(KeyCode.W))
        {
            print("W has been Pressed");
            Accelarate();
        }
        else
        {
            pressTime = 0.0f;
        }
        //ativates lean when A or D is pressed
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D))
        {
            lean();
        }
        //Activates hitTheBreaks when S is pressed
        if (Input.GetKey(KeyCode.S))
        {
            hitTheBreaks();
        }
        else {
        pressTime = 0.0f;
        }
       
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime * multiplyer;

    }
    */
    public void Update()
    {

    }
}
