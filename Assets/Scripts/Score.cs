using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public Text scoreText;
     public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<Text>;
        scoreAmount =0;
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
            scoreText=GameObject.Find("ScoreText").GetComponent<Text>(); 
            Debug.Log(scoreText);
            scoreAmount = scoreAmount + 1;
            scoreText.text =  "Score: " + scoreAmount.ToString();
            Destroy(gameObject);
            
        }
    }
}
