using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp_move : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.transform.position = Vector3.MoveTowards(transform.position, collision.transform.position, speed * Time.deltaTime);
        }
    }
}
