using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdJump : MonoBehaviour
{
    public Rigidbody2D bird;
    public float jumpForce;

    public static int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bird.velocity = new Vector2(0, jumpForce);
        }

        scoreText.text = score.ToString();
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
            SceneManager.LoadScene(0);
            return;
        }

        if (collision.gameObject.tag == "Score")
        {
            score++;
            return;
        }


    }
}
