using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstGameManager : MonoBehaviour
{
    static FirstGameManager gameManager;
    public static FirstGameManager Instance { get => gameManager; }

    private void Awake()
    {
        gameManager = this;
    }

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
    }

    public void GameStart()
    {

    }

    public void GameOver()
    {

    }

    public void Restart()
    {

    }

    public void GameScore()
    {

    }


}
