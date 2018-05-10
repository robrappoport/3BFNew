using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    public Vector3 targetPos;
    public KeyCode clickToMove, clickToInteract;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMovement();

    }

    void PlayerMovement()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        if (Input.GetKeyDown(clickToMove))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * moveSpeed);
    }

}
