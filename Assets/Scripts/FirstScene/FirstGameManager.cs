using UnityEngine;

public class FirstGameManager : MonoBehaviour
{
    static FirstGameManager gameManager;
    public static FirstGameManager Instance { get => gameManager; }

    private FirstUIManager uiManager;

    private float playTime { get; set; }

    public bool isPlayedOnce = false;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        uiManager = FindObjectOfType<FirstUIManager>();
        
    }

    void Start()
    {
        Time.timeScale = 0;
        playTime = 0;
    }

    void Update()
    {
        playTime += Time.deltaTime;
    }

    public void GameStart()
    {
        Time.timeScale = 1.0f;
        playTime = 0;
        uiManager.StartGame();
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
