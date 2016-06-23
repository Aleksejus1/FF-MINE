using UnityEngine;
using System.Collections;
using Control;
using System;

[Serializable]
public class player : MonoBehaviour {
    public int playerId = 1;
    Main gc;
    KeyControl kc;
    Rigidbody rb;
    public float movementSpeed = 1f;
    void Start () {
        rb = GetComponent<Rigidbody>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<Main>();
        kc = gc.control;
	}
	void Update () {
        move();
        rotate();
	}
    void rotate() {
        transform.Rotate(0, -40 * Time.deltaTime, 0);
    }
    void move(){
        float vertical = 0f, horizontal = 0f, speed = Time.deltaTime * movementSpeed * 5;
        if ((playerId == 1 && kc.Pressed(Key.Up)) || (playerId == 2 && kc.Pressed(Key.UpP2))) vertical += speed;
        if ((playerId == 1 && kc.Pressed(Key.Down)) || (playerId == 2 && kc.Pressed(Key.DownP2))) vertical -= speed;
        if ((playerId == 1 && kc.Pressed(Key.Left)) || (playerId == 2 && kc.Pressed(Key.LeftP2))) horizontal -= speed;
        if ((playerId == 1 && kc.Pressed(Key.Right)) || (playerId == 2 && kc.Pressed(Key.RightP2))) horizontal += speed;
        //if (vertical != 0) horizontal = 0;
        if (horizontal != 0 || vertical != 0) move(new Vector2(horizontal, vertical));
    }
    void move(Vector2 direction) {
        rb.MovePosition(rb.position + new Vector3(direction.x, 0f, direction.y));
    }
}
