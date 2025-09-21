using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float friction;
	private Rigidbody2D body;
    void Start()
    {
		body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
			Vector2 movement = new Vector2(0,0);
        if(Input.GetKey (KeyCode.W))
        {
            movement += new Vector2(0, 1);
        }
		if(Input.GetKey (KeyCode.S))
        {
            movement += new Vector2(0, -1);
        }
        if(Input.GetKey (KeyCode.D))
        {
                movement += new Vector2(1, 0);
        }
        if(Input.GetKey (KeyCode.A))
        {
                movement += new Vector2(-1, 0);
        }
        body.linearVelocity = Vector2.Lerp(body.linearVelocity, movement.normalized*moveSpeed,friction* Time.fixedDeltaTime);
    }
}
