using UnityEngine;
using UnityEngine.UI;

public class ScoreScrpt : MonoBehaviour
{
    public int score;
    public Text textDisplayer;

    void Start()
    {
        score = 0;
    }

    public void ScoreUp()
    {
        textDisplayer.text = score.ToString();
    }
    
    
}
