using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasIcecreem = false;
    [SerializeField]float delay = 0f;

    void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Icecreem") && hasIcecreem == false)
        {
            Debug.Log("Picked up");
            Debug.Log("Dillever the Icecreem");
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
            hasIcecreem = true;
        }

        if(collision.CompareTag("Customer") && hasIcecreem)
        {
            Debug.Log("Delivered");
            hasIcecreem = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
}
