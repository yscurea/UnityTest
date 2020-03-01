using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Weapon
{
	public class GunController : MonoBehaviour
	{
		[SerializeField]
		private GameObject bullet;

		private float bulletSpeed = 20.0f;

		private int bulletNum = 100;

		private float positionMargin = 1.0f;



		public void Shoot()
		{
			if (bulletNum > 0)
			{
				Vector3 startPosition = this.transform.position;

				startPosition += this.transform.forward * positionMargin;

				GameObject bulletTmp = Instantiate(bullet, startPosition, this.transform.rotation);

				bulletTmp.GetComponent<Rigidbody>().velocity = this.transform.forward * bulletSpeed;

				bulletNum--;
			}
			else
			{
				//弾切れ
			}
		}
	}
}