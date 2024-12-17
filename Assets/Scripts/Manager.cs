using UnityEngine;

public class Manager : MonoBehaviour
{

    public int score = 0;
    public int lives = 3;
    public Vector3 ballStartPos = Vector3.zero;

    void ResetGame()
    {
        score = 0;
        lives = 3;
    }

    /*public void DecrementLives(GameObject ball)
    {
        lives--;
        ball.transform.position = ballStartPos;
        ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero; 
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
    }*/


}
