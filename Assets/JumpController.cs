using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float jumpSpeed;
    public ScoreKeeper scoreKeeper;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(new Vector3(0,0,90));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidbody2D.velocity = Vector2.up * jumpSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreKeeper.gameOver();
        birdIsAlive = false;
    }
}
