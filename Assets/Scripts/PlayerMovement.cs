using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool can_jump = true;
    //private float gravity_strength = 10.0f;
    private float jump_power = 120.0f;
    private float walk_power = 60.0f;
    private int jump_timer = 0;
    private int jump_length = 10;
    private int rotate_speed = 5;
    private float xRotation = 0f;
    public float mouseSensitivity = 10f;
    Rigidbody body;
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        //modified GPT FPS camera code{https://chatgpt.com/share/670de0ea-5738-8007-87ea-121dc6ef8ebd

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;

        // Calculate the up/down rotation and clamp it
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Apply the rotation to the camera (up/down)
        gameObject.transform.GetChild(0).transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the player's body (left/right)
        body.transform.Rotate(Vector3.up * mouseX);

        //}
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(Physics.Raycast(transform.position, -transform.up, 1))
        {
            can_jump = true;
            jump_timer = 0;
        }
        else if (jump_timer >= jump_length || (Input.GetButtonUp("Jump") && jump_timer >= (jump_length/2))) can_jump = false;

        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log("Left/Right");
            body.AddForce(transform.right * walk_power * Input.GetAxis("Horizontal"));

        }
        if (Input.GetAxis("Vertical") != 0)
        {
            Debug.Log("Forwards/Backwards");
            body.AddForce(transform.forward * walk_power * Input.GetAxis("Vertical"));
        }
        if (Input.GetButton("Jump") && can_jump)
        {
            Debug.Log("Jump");
            jump_timer++;
            body.AddForce(Vector3.up * jump_power);
        }


        
    }
}
