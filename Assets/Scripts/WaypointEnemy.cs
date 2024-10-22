using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WaypointEnemy : MonoBehaviour
{
    public float speed;
    public List<GameObject> targets;
    GameObject currentTarget;
    int t;

    void Start()
    {
        currentTarget = targets[t];
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, currentTarget.transform.position) < 0.5f)
        {
            currentTarget = targets[t++];
        }
        if (t >= targets.Count) t = 0;

        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, speed);
    }
}
