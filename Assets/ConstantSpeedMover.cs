using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedMover : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float deadZone = -23;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            // Debug.Log("delete object");
            Destroy(gameObject);
        }
    }
}
