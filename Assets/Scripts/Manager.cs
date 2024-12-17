using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

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
        set;
    }
    public int Lives { get; set; }

    public Vector3 ballStartPos = Vector3.zero;
    public GameObject scoreboard;

    void Start()
    {
        Physics.gravity = new Vector3(0, -20f, 0);
    }

    public void IncreaseScore(int increment) {

    }

    /*public void DecrementLives(GameObject ball)
    {
        lives--;
        ball.transform.position = ballStartPos;
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero; 
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
    }*/


}
