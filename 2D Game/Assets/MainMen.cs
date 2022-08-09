using UnityEngine;

public class MainMen : MonoBehaviour
{
    public BarrierSpawnner spawnner;
    public GameObject CanvasObject;

    public void Go()
    {
        spawnner.StartedGame = true;
        CanvasObject.GetComponent<Canvas> ().enabled = false;
    }
}
