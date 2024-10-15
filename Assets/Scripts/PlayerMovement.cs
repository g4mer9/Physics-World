using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 velocity;
    private bool can_jump = true;
    private float gravity_strength = 10.0f;
    private float jump_power = 8.0f;
    private float walk_power = 5.0f;
    private int jump_timer = 0;
    private int jump_length = 45;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody body = gameObject.GetComponent<Rigidbody>();
        //raycast down a few units to check grounded, else vel.y = 0f

        //stop jumping and let gravity take over?
        /**else*/
        if (jump_timer >= jump_length || Input.GetButtonUp("Jump")) can_jump = false;

        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log("Left/Right");

        }
        if (Input.GetAxis("Vertical") != 0)
        {
            Debug.Log("Forwards/Backwards");
        }
        if (Input.GetButton("Jump") && can_jump)
        {
            Debug.Log("Jump");
            jump_timer++;
            body.AddForce(Vector3.up * jump_power);
        }
    }
}
