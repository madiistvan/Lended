using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{
	public float moveSpeed = 3f;
	float dirX; 
	bool moveRight = true;

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y > 4f)
			moveRight = false;
		if (transform.position.y < -4f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.y + moveSpeed * Time.deltaTime, transform.position.x);
		else
			transform.position = new Vector2(transform.position.y - moveSpeed * Time.deltaTime, transform.position.x);
	}
}
