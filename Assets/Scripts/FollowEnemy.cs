using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public GameObject target;
    public float speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
