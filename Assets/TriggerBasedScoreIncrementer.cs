using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasedScoreIncrementer : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public LayerMask triggerLayer;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreKeeper>();
        // Debug.Log(scoreKeeper);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            // Debug.Log("add score");
            scoreKeeper.IncrementScore();
            return;
        }
    }

}