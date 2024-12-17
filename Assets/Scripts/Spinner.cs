using UnityEngine;

public class Spinner : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z == 0) 
        {
            Manager.score += 100;
            Debug.Log(Manager.score);
        }
    }
}
