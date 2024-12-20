using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject ballSpawn;
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("GameManager is null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public int Score 
    { 
        get;
        private set;
    }
    public int Lives { get; set; } = 999;

    public Vector3 ballStartPos = Vector3.zero;
    public GameObject scoreboard;


    public void IncreaseScore(int increment) {
        Score += increment;
        scoreboard.GetComponent<TextMeshPro>().text = "SCORE: " + Score;
    }

    public void KillBall(GameObject ball) {
        if (Lives > 0)
        {
            Lives--;
            ball.transform.position = ballSpawn.transform.position;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Debug.Log("Ball lost");
        }
        else
        {
            Debug.Log("Game over!");
        }   
    }

    public void TriggerTilt() {
        //Todo!
        Debug.Log("TILT!!!!!!!!");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            KillBall(GameObject.Find("Pinball"));
        }
    }

    /*public void DecrementLives(GameObject ball)
    {
        lives--;
        ball.transform.position = ballStartPos;
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero; 
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
    }*/


}
