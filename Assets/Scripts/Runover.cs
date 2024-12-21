using UnityEngine;

public class Runover : MonoBehaviour
{
    public int basePoints = 100;
    public bool isLit = false;
    

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.IncreaseScore(basePoints);
    }
}
