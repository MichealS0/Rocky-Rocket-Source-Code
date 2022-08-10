using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increadeScore : MonoBehaviour
{
    public ScoreScrpt sc;

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            sc.score++;
            sc.ScoreUp();
        }
    }
}
