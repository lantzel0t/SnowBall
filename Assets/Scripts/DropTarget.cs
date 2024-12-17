using UnityEngine;

public class DropTarget : MonoBehaviour
{
    public float pushMult = 20.0f;
    private bool isTriggered = false;
    private Vector3 origPos;
    Vector3 droppedPos;
    
    void Start()
    {
        origPos = this.transform.position;
        droppedPos = origPos;
        droppedPos.y -= 3f;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        Vector3 angle = (other.gameObject.transform.position
            - this.transform.position) * pushMult;
        Debug.Log("Droptargeting ball at: " + angle);
        
        other.gameObject.GetComponent<Rigidbody>().AddForce(angle, ForceMode.Impulse);
        isTriggered = true;

        //other.gameObject.GetComponent<Rigidbody>().linearVelocity *= -pushMult;
    }

    void Update()
    {
        if (isTriggered) 
        {
            this.gameObject.transform.position = Vector3.Lerp(
                this.gameObject.transform.position, droppedPos, 0.5f); 
        } 
        else 
        {
            this.gameObject.transform.position = Vector3.Lerp(
                this.gameObject.transform.position, origPos, 0.5f); 
        }
    }
}
