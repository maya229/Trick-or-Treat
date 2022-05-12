using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Button button;
    private GameManger gm;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gm = GameObject.Find("GameManger").GetComponent<GameManger>();

    }
    void setDifficulty()
    {
        Debug.Log("You chose" + gameObject.name);
        gm.StartGame(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
