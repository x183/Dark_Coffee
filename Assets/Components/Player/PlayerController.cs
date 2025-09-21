using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
	private Rigidbody2D body;
    void Start()
    {
		body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
			Vector2 movement = new Vector2(0,0);
        if(Input.GetKeyDown (KeyCode.W))
        {
            movement += new Vector2(0, 1);
        }
		if(Input.GetKeyDown (KeyCode.S))
        {
            movement += new Vector2(0, -1);
        }
        if(Input.GetKeyDown (KeyCode.D))
        {
                movement += new Vector2(1, 0);
        }
        if(Input.GetKeyDown (KeyCode.A))
        {
                movement += new Vector2(-1, 0);
        }
		  body.AddForce((movement.normalized) * moveSpeed);
    }
}
