using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other != null && other.tag == "Player")
        {
            Debug.Log("collision");
            //adapted from lecture script
            Vector3 contact_point;
            contact_point = transform.position;

            collision.rigidbody.AddExplosionForce(5000, contact_point, 20);
        }
    }

}
