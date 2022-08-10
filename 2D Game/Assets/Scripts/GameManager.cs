using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Script Refrences
    public BarrierSpawnner spawnner;
    public MainMen menu;
    public MoveLeft moveLeft;
    public rockeyMovement movement;

    void Start()
    {
        spawnner.StartedGame = false;
        movement.dead = false;
        spawnner.StartedGame = false;
        movement.rend.enabled = true;
    }

    void Update()
    {
        if (spawnner.StartedGame)
        {
            menu.menuOn = false;
        }

        if (movement.dead == true)
        {
            spawnner.StartedGame = false;
        }

        if (spawnner.StartedGame == false)
        {
            menu.menuOn = true;
        }
    }
}
