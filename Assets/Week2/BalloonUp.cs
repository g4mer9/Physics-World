using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonUp : MonoBehaviour
{

    Rigidbody myRB;
    private float startY;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myRB.AddForce(Vector3.up,ForceMode.VelocityChange);
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        myRB.AddForce(Vector3.up * Time.deltaTime);
        if (transform.position.y > startY + 25)
            Destroy(this);
    }
}
