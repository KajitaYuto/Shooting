using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D)){
            pos.x += 0.01f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.01f;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            pos.z += 0.01f;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            pos.z -= 0.01f;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
