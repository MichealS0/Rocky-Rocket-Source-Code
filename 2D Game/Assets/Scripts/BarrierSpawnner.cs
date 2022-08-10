using UnityEngine;

public class BarrierSpawnner : MonoBehaviour
{
    public GameObject barrierPrefab;
    public float yMin, yMax;
    public float Tmax;
    public float Timer;
    public float LeftSpeed;
    public bool StartedGame;

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= Tmax && StartedGame)
        { 
                       
            newObstacle();
            Timer = 0f;

        }
        
    }

    private void newObstacle()
    {

        float randPosY = Random.Range(yMin, yMax);
        GameObject anotherObstacle = Instantiate(barrierPrefab);
        
        if (StartedGame)
        {
            anotherObstacle.transform.position = new Vector2(transform.position.x, randPosY);
        }
    }
}
