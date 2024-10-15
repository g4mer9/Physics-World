using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookShoot : MonoBehaviour
{
    public GameObject ball;
    private GameObject lastBall;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        lastBall = Instantiate(ball, transform.position, transform.rotation, transform);
		lastBall.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 4, ForceMode.Impulse);

    }
}
