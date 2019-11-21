using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float DaytimeTimer;
    public float DaytimeLength;
    public bool CountdownEnabled;

    public int Demons;
    public int TilesTurned;
    public int StartingDemons;

    public int DaysPassed;

    public Canvas GameOverCan;
    public Canvas WinCan;

    [SerializeField]
    private GameObject gameOverGO;
    private Coroutine gameOverCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        DaytimeTimer = DaytimeLength;
        CountdownEnabled = true;
        Demons = StartingDemons;
        GameOverCan.enabled = false;
        WinCan.enabled = false;

        gameOverGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownEnabled == true) 
        {
            DaytimeCountdown();
        }


        if (DaytimeTimer <= 0) 
        {
            DayEnd();
        }

        if (Demons <= 0) 
        {
            GameOverCan.enabled = true;
            SceneManager.LoadScene("GameOverMenu");
        }

        if (TilesTurned == 64) 
        {
            WinCan.enabled = true;
        }

        if (DaysPassed > 29)
        {
            if (gameOverCoroutine == null) gameOverCoroutine = StartCoroutine(GameOver());
        }

    }

    void DaytimeCountdown() 
    {
        DaytimeTimer = DaytimeTimer -= Time.deltaTime;
    }


    public void DayEnd() 
    {
        Demons += TilesTurned * 20;
        DaytimeTimer = DaytimeLength;
        DaysPassed += 1;
    } 

    private IEnumerator GameOver()
    {
        gameOverGO.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("GameOverMenu");
    }
}
