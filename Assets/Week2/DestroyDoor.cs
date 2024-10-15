using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
    public GameObject door;

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{

			if (Input.GetButton("Fire1"))
			{
				Destroy(door);
			}
		}
	}
}
