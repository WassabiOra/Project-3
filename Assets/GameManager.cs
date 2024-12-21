using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject targetSquarePrefab;
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public float gameDuration = 30f;

    private int score = 0;
    private float timer;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = gameDuration;
        SpawnNewSquare();
        StartCoroutine(StartTimer());
    }

    public void SpawnNewSquare()
    {
        Vector2 spawnPosition = new Vector2(UnityEngine.Random.Range(-8, 8), UnityEngine.Random.Range(-4, 4));
        Instantiate(targetSquarePrefab, spawnPosition, Quaternion.identity);
    }

    IEnumerator StartTimer()
    {
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateUI();
            yield return null;
        }
        GameOver();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        timerText.text = "Time: " + Mathf.Round(timer).ToString();
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    void GameOver()
    {
        UnityEngine.Debug.Log("Game Over! Final Score: " + score);


        SceneManager.LoadScene(sceneName: "Game Over");
    }
}