using UnityEngine;

public class MainMen : MonoBehaviour
{
    public BarrierSpawnner spawnner;
    public GameObject CanvasObject;
    public bool menuOn;

    void Update()
    {
        if (menuOn)
        {
            CanvasObject.GetComponent<Canvas> ().enabled = true;
        }


    }
    public void Go()
    {
        spawnner.StartedGame = true;
        CanvasObject.GetComponent<Canvas> ().enabled = false;
    }
}
