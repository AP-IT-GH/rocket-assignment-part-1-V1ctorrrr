using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class myGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverCanvas;
    public enum GamesStates
    {
        Playing,
        GameOver
    }

    public GamesStates gameState = GamesStates.Playing;
    private Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        if (player==null)
        {
            player = GameObject.FindWithTag("Player");
        }

        playerHealth = player.GetComponent<Health>();
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GamesStates.Playing:
                if (!playerHealth.isAlive)
                {
                    gameState = GamesStates.GameOver;
                    gameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
