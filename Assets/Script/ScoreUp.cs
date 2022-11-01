using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Score.score += 1;
    }
}
