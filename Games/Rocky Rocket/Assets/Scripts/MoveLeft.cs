using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float leftSpeed;
    public float maxLeft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - leftSpeed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= maxLeft)
        {
            Destroy(gameObject);
        }
    }

}