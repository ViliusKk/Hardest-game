using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        dir.Normalize();
        transform.position += dir * speed;
    }


    void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.name.Contains("Enemy"))
        {
            transform.position = startPos;
        }
    }
}
