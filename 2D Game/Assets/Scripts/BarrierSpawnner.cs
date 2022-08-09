using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawnner : MonoBehaviour
{
    public GameObject barrierPrefab;
    public float yMin, yMax;
    public float Tmax;
    public float Timer;
    public float LeftSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= Tmax)
        {
            newObstacle();
            Timer = 0f;
        }
        
    }

    private void newObstacle()
    {

        float randPosY = Random.Range(yMin, yMax);
        GameObject anotherObstacle = Instantiate(barrierPrefab);
        anotherObstacle.transform.position = new Vector2(transform.position.x, randPosY);

    }
}
