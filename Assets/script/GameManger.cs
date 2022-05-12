using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManger : MonoBehaviour
{
    public List<GameObject> candiesPrefab;
    public float WaitTime = 6;
    public TextMeshProUGUI ScoreTest;
    public int Score=0;
    public GameObject buttons;
    public TextMeshProUGUI GameOverrr;
    public bool GameActive;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void StartGame(int difficulty)
    {
        GameActive = true;
        WaitTime=WaitTime/difficulty;
        buttons.gameObject.SetActive(false);
        StartCoroutine(spawnprefab());
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator spawnprefab()
    {


        while (GameActive)
        {
            yield return new WaitForSeconds(WaitTime);
            int index = Random.Range(0, candiesPrefab.Count);
            Instantiate(candiesPrefab[index]);
        }
    }
    public void UpdateScore(int ScoreVal)
    {
        Score += ScoreVal;
        ScoreTest.text = "Score: " + Score;
        if( Score < 0)
        {
           GameOver();
        }
    }
    void GameOver()
    {
        GameOverrr.gameObject.SetActive(true);
        GameActive = false;
    }
}
