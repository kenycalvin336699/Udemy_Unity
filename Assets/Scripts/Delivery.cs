using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasIcecreem = false;

    void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Icecreem"))
        {
            Debug.Log("Picked up");
            Debug.Log("Dillever the Icecreem");
            hasIcecreem = true;
        }

        if(collision.CompareTag("Customer") && hasIcecreem)
        {
            Debug.Log("Delivered");
            hasIcecreem = false;
        }
    }
}
