using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candies : MonoBehaviour
{

    private GameObject candiesPrefab;
    private float startForce = 50;
    private Rigidbody2D candiesrg;
    public ParticleSystem exp;
    public GameManger GameManger;
    public int pointVal;
   
    void Start()
    {
        GameManger = GameObject.Find("GameManger").GetComponent<GameManger>();
        candiesrg = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(Random.Range(-250, 180), Random.Range(-100, -100));
        candiesrg.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        

    }
    private void OnMouseDown()
    {
        if (GameManger.GameActive)
        {
            GameManger.UpdateScore(pointVal);
            Destroy(gameObject);
            
            Instantiate(exp, transform.position, exp.transform.rotation);
            exp.Play();
        }
    }

    
    void Update()
    {

    }
  
}
