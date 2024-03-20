using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Ghost : MonoBehaviour
{
    public float speed = 5f;
    public Transform targetPosition;
    void Start()
    {
        targetPosition = GameObject.Find("EndGhostPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);

        if (transform.position == targetPosition.position)
        {
            Destroy(gameObject);
        }
    }
}
