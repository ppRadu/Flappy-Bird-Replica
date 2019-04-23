using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject newObstaclePosition;
    public int minGapHeight;
    public int maxGapHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Instantiate(obstacle, 
                new Vector2(newObstaclePosition.transform.position.x, Random.Range(minGapHeight, maxGapHeight+1)), 
                Quaternion.identity);
            Destroy(collision.gameObject);

        }
    }
}
