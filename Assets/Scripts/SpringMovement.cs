using UnityEngine;

public class MoveObjectOnSpace : MonoBehaviour
{
    public float moveSpeed = 1f; // Speed at which the object moves along the X-axis
    
    
    private Vector3 resetPosition; // Store the initial position of the object
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position when the script starts
        resetPosition = new Vector3(0.433f, 0.137f , 2.256f);
    }

    void Update()
    {
        // Check if spacebar is being held down
        if (Input.GetKey(KeyCode.Space))
        {
            // Move the object along the x-axis
            transform.position = new Vector3(initialPosition.x + moveSpeed * Time.time, transform.position.y, transform.position.z);
        }
        else
        {
            // Reset the object's position to the initial one when spacebar is not held
            transform.position = resetPosition;
        }
    }
}
