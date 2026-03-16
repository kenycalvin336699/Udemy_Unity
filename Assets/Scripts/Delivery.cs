using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool delivery = false;

    void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Icecreem"))
        {
            Debug.Log("Picked up");
            Debug.Log("Dillever the Icecreem");
            delivery = true;
        }

        else if(collision.CompareTag("Customer") && delivery)
        {
            Debug.Log("Delivered");
            delivery = false;
        }
    }
}
