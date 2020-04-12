using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateBoardMovement : MonoBehaviour
{
    Rigidbody rb;
    public bool falling; // if we don't wnat players to drastically move or accelerate wile in mid air
    public float reducedSpeedOverTime; // how the speed reduces to a stop (may or may not be obselete after tutorial
    public float moveSpeed; // current speed (may or may not be obselete after tutorial
    public float jumpHeight; // calculated jump hight when in mid air,  (may or may not be obselete after tutorial
    public int addedForwardMomentum;
    public int addedJumpMomentum;
    public List<GameObject> motherPoints;
    public GameObject prop;
    public GameObject CM;


    //for forward direction alteration
    private Vector3 targetDirection;

    //class will showcase basic movement properties
    //objects with this script should be able to move left and right, accelarate, and brake
    //objects with this class should also be able to jump and manuver in the air without flying into outerspace.
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = CM.transform.localPosition;
        reducedSpeedOverTime = Time.deltaTime;
    }


    public void Update()
    {
        //actual movement and speed being added
        rb.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * 400f, prop.transform.position);
        rb.AddTorque(Time.deltaTime * transform.TransformDirection(Vector3.up) * Input.GetAxis("Horizontal") * 30f);
        //makes sure everythin
        foreach (GameObject motherPoint in motherPoints)
        {
            RaycastHit hit;
            if (Physics.Raycast(motherPoint.transform.position, transform.TransformDirection(Vector3.down), out hit, 3f))
            {
                rb.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.up) * Mathf.Pow(3f - hit.distance, 2) / 3f * 250f, motherPoint.transform.position);
            }
            Debug.Log(hit.distance);
        }
        rb.AddForce(-Time.deltaTime * transform.TransformVector(Vector3.right) * transform.InverseTransformVector(rb.velocity).x * 5f);
    }

    /*
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
}
