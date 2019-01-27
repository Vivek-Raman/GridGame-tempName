using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float LeashLength = 2.0f;

    [SerializeField] private float MovementSpeed = 3f;
    private Vector2 initPos;
	
	void Update ()
    {
        initPos = transform.position;
	}

    private void FixedUpdate()
    {
        float dispH = Input.GetAxisRaw("Horizontal") * LeashLength;
        float dispV = Input.GetAxisRaw("Vertical") * LeashLength;
        float newX = Mathf.Lerp(initPos.x, dispH, MovementSpeed * Time.deltaTime);
        float newY = Mathf.Lerp(initPos.y, dispV, MovementSpeed * Time.deltaTime);
        transform.position = new Vector2(newX, newY);
    }
}
