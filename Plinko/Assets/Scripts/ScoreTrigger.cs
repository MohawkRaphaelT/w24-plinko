using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public int points = 5;
    public Score score;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        score.AddToScore(points);
    }
}
