using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	Transform camTransform;
	public float shakeDuration = 0;
	float shakeAmount = 0.2f;
	float decreaseFactor = 1.0f;
	Vector3 originalPos;
	GameObject player;

	void Start()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
			originalPos = camTransform.localPosition;
		}

		this.player = GameObject.Find("Player");
	}

	void Update()
	{
		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}

		else
		{
			shakeDuration = 0f;
		}

		Vector3 playerPos = this.player.transform.position;

		if (-8.5f < playerPos.x && playerPos.x < 1.6f)
		{
			camTransform.position = new Vector3(playerPos.x, camTransform.position.y, camTransform.position.z);
		}
	}
}