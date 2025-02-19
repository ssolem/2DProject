using UnityEngine;

public class FirstGameManager : MonoBehaviour
{
    static FirstGameManager gameManager;
    public static FirstGameManager Instance { get => gameManager; }

    private FirstUIManager uiManager;

    private float playTime;

    public float PlayTime { get { return playTime; } }

    public bool isPlayedOnce = false;

    public bool gameOver = true;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(gameObject);
        }

        uiManager = FindObjectOfType<FirstUIManager>();
        Time.timeScale = 0;
    }

    void Start()
    {

    }

    void Update()
    {
        if (gameOver)
            return;
        playTime += Time.deltaTime;
    }

    public void GameStart()
    {
        gameOver = false;
        Time.timeScale = 1;
        playTime = 0;
        uiManager.StartGame();
    }

    public void GameOver()
    {
        gameOver=true;
        Time.timeScale = 0;
        uiManager.GameOver();
    }

    public void Restart()
    {

    }

    public void GameScore()
    {

    }


}
