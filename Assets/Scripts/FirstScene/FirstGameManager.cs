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
        
    }

    void Update()
    {
        
    }

    private void GameStart()
    {

    }

    private void GameOver()
    {

    }

    private void Restart()
    {

    }

    private void GameScore()
    {

    }


}
