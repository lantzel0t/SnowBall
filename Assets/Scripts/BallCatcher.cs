using UnityEngine;

public class BallCatcher : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.KillBall(other.gameObject);
    }
}
