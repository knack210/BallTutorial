using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Also used with sliding penalty
public class SlidingWall : MonoBehaviour {

    public float speed;
    public int direction;
    private float start;

	void Start ()
    {
        start = transform.position.x;
	}
	
	void Update ()
    {
        // Found this function after doing a bit of research online
        transform.position = new Vector3(start + Mathf.PingPong(Time.time * speed, direction), transform.position.y, transform.position.z);
	}
}
