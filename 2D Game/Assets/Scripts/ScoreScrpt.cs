using UnityEngine;
using UnityEngine.UI;

public class ScoreScrpt : MonoBehaviour
{
    public int score;

    void Start()
    {
        score = 0;
    }

    public void ScoreUp()
    {
        GetComponent<Text>().text = score.ToString();
    }
    
    
}
