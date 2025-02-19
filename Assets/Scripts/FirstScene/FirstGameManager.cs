using UnityEngine;

public class FirstGameManager : MonoBehaviour
{
    static FirstGameManager gameManager;
    public static FirstGameManager Instance { get => gameManager; }

    private FirstUIManager uiManager;

    private Player player;

    Animations animations;

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
        player = FindObjectOfType<Player>();
        animations = FindObjectOfType<Animations>();

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
        gameOver = false;
        Time.timeScale = 1;
        playTime = 0;
        //플레이어 위치 변경
        player.GetInitLocation();
        //목표 다시 원상복구
        animations.RestartGame();
        uiManager.StartGame();
    }

    public void GameScore()
    {

    }


}
