using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Crash");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Speed increase");        
    }
}
