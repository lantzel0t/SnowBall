using UnityEngine;

public class DropTarget : MonoBehaviour
{
    public float pushMult = 20.0f;
    public float dropAmount = 0.55f;
    public int points = 1000;
    private bool isTriggered = false;
    private Vector3 origPos;
    Vector3 droppedPos;
    
    void Start()
    {
        origPos = this.transform.position;
        droppedPos = origPos;
        droppedPos.y -= dropAmount;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        Vector3 angle = (transform.forward * pushMult);
        Debug.Log("Droptargeting ball at: " + angle);
        
        other.gameObject.GetComponent<Rigidbody>().AddForce(angle, ForceMode.Impulse);
        GameManager.Instance.IncreaseScore(points);
        isTriggered = true;

        //other.gameObject.GetComponent<Rigidbody>().linearVelocity *= -pushMult;
    }

    void Update()
    {
        if (isTriggered) 
        {
            this.gameObject.transform.position = Vector3.Lerp(
                this.gameObject.transform.position, droppedPos, 0.1f); 
        } 
        else 
        {
            this.gameObject.transform.position = Vector3.Lerp(
                this.gameObject.transform.position, origPos, 0.1f); 
        }
    }
}
