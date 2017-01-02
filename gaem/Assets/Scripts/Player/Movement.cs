using UnityEngine;
using System.Collections;
using System;

public class Movement : MonoBehaviour {

    private Vector3 pos;
    private float movement_distance;

    // Use this for initialization
    void Start () {
        pos = transform.position;
        movement_distance = 64/100f;
    }
	
	// Update is called once per frame
    void Update () {

            if (Input.GetKeyDown(KeyCode.D))
            {
                pos = new Vector3(pos.x + movement_distance, pos.y, pos.z);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                pos = new Vector3(pos.x - movement_distance, pos.y, pos.z);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                pos = new Vector3(pos.x, pos.y + movement_distance, pos.z);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                pos = new Vector3(pos.x, pos.y - movement_distance, pos.z);
            }

            if (pos != transform.position)
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position, pos, movement_distance);
                
                if (hit.collider != null)
                {
                    Debug.DrawRay(transform.position,pos, Color.green);
                    Debug.Log(hit.collider.gameObject.tag);
                }
               

            }

            transform.position = pos;
    
    }
}
