using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ForwardsForce = 2000f;
    public float SidewaysForce = 500f;
    public float ClimbForce = 2000f;
    public float JumpForce = 40000f;
    public CharacterSelector CurrentPlayer;
    public Rigidbody rb;
    public Transform PlayerDirection;
    public bool CanJump;
    public bool CanClimb;
    // Start is called before the first frame update
    void Start()
    {
        float SpeedMultiplier = PlayerPrefs.GetInt("Speed");
        Debug.Log(SpeedMultiplier);
        // ForwardsForce = ForwardsForce*PlayerPrefs.GetInt("Speed");
        // SidewaysForce = SidewaysForce*PlayerPrefs.GetInt("Speed");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && CanJump == true)
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a") && CanJump == true)
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, ForwardsForce * Time.deltaTime);
        }
        if(Input.GetKey("e") && CanClimb == true)
        {
            rb.AddForce(0, ClimbForce * Time.deltaTime, 0);
        }
        if(Input.GetKey("c") && CanClimb == true)
        {
            rb.AddForce(0, -ClimbForce * Time.deltaTime, 0);
        }
        if(Input.GetKey("s") && CanJump == true)
        {
            rb.AddForce(0, 0, -ForwardsForce * Time.deltaTime);
        }
        if(Input.GetKey("space") && CanJump == true)
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0);
        }
        if(rb.position.y < .8)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
