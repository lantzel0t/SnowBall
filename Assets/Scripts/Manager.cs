using UnityEngine;

public class Manager : MonoBehaviour
{

    public int score = 0;
    public int lives = 3;
    public vector3 ballStartPos = Vector3.zero;

    void ResetGame()
    {
        score = 0;
        lives = 3;
    }

    void DecrementLives(gameObject ball)
    {
        lives--;
        ball.transform.position = ballStartPos;
        ball.rigidbody.velocity = Vector3.zero; 
        ball.rigidbody.angularVelocity = Vector3.zero; 
    }


}
