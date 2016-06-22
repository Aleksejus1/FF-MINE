using UnityEngine;
using System.Collections;
using Control;

public class player : MonoBehaviour {
    Rigidbody2D body = null;
    float movementSpeed = 10f;
    void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	void Update () {
        move();
	}
    void move()
    {
        if (KeyControl.Pressed(Key.Up))     body.AddForce(new Vector2(0f, movementSpeed));
        if (KeyControl.Pressed(Key.Left))   body.AddForce(new Vector2(-movementSpeed, 0f));
        if (KeyControl.Pressed(Key.Down))   body.AddForce(new Vector2(0f, -movementSpeed));
        if (KeyControl.Pressed(Key.Right))  body.AddForce(new Vector2(movementSpeed, 0f));
    }
}
