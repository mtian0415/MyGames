using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_MoveCircle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("My position is " + this.transform.position.ToString());
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 curr = this.transform.position;
            curr.x -= 0.1f;
            this.transform.position = curr;
        }
    }
}
