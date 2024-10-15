using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBalloons : MonoBehaviour
{
    public GameObject balloon;
	bool isInTrigger;

	private void Update()
	{
		if (isInTrigger && Input.GetButtonDown("Fire1"))
		{
			Instantiate(balloon, transform.position + Vector3.up, Quaternion.identity);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			isInTrigger = true;

		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			isInTrigger = false;

		}
	}
}
