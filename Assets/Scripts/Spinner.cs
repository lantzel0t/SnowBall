using UnityEngine;

public class Spinner : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z == 0) 
        {
            GameManager.Instance.Score += 100;
        }
    }
}
