using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushDoor : MonoBehaviour
{
    public Rigidbody door;
    public string open_tag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        if (other.tag == open_tag)
        {
            Debug.Log("Trigger enter by Player");
        }
    }

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == open_tag)
		{
            if (Input.GetButton("Fire1"))
            {
                Debug.Log("Trigger pressed by Player");
                door.isKinematic = false;
                door.AddForce((transform.position - other.transform.position) * 10, ForceMode.Impulse);
            }
		}
	}
}
