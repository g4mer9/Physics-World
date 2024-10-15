using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPad : MonoBehaviour
{
    public Transform spawn_pos;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay(Collider other)
    {
        if (other != null && other.tag == "Player")
        {
            Debug.Log("ball_trigger");
            GameObject ball_i = Instantiate(ball, spawn_pos.position, spawn_pos.rotation);
        }
    }
}
