using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//[SerializeField]
	//private Status status;

	[SerializeField]
	private GameObject gun;
	[SerializeField]
	private Weapon.GunController gunController;

	private int shootSpan = 10;
	private int spanTime = 10;

	void Start()
	{
		gunController = gun.GetComponent<Weapon.GunController>();
	}

	void Update()
	{
		Action();
	}

	private void FixedUpdate()
	{
		
	}

	private void Action()
	{
		if (Input.GetMouseButton(0))
		{
			shootSpan--;
			if (shootSpan == 0)
			{
				shootSpan = spanTime;
				gunController.Shoot();
			}
		}
	}



}
