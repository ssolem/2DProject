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
        playTime += Time.deltaTime;
    }

    public void GameStart()
    {
        Time.timeScale = 1;
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
