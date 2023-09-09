using UnityEngine;

public class Motorcycle_Script : MonoBehaviour
{
	Rigidbody2D _rigidbody;
	readonly float speed = 20;

	void Start()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		MoveHorizontal();
		MoveVertical();
	}

	void MoveHorizontal()
	{
		float right = Input.GetAxis("Horizontal");
		if (right != 0)
		{
			var pos = transform.position;
			pos += Vector3.right * right * Time.deltaTime * speed;
			_rigidbody.MovePosition(pos);
		}
	}

	void MoveVertical()
	{
		float up = Input.GetAxis("Vertical");
		if (up != 0)
		{
			var pos = transform.position;
			pos += Vector3.up * up * Time.deltaTime * speed;
			_rigidbody.MovePosition(pos);
		}
	}

}
