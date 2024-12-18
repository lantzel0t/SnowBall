using UnityEngine;

public class Spinner : MonoBehaviour
{
    private int neg = -1;
    public int pointsPerSpin = 100;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.rotation.z * neg > 0) 
        {
            GameManager.Instance.IncreaseScore(pointsPerSpin);
            neg *= -1;
        }
    }
}
