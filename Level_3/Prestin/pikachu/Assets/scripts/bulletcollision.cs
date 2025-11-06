using UnityEngine;

public class Collisiondetection : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Bullet"))
        {
           
            Destroy(other.gameObject);
            
            Debug.Log("Bullet has exited the trigger zone.");
            Destroy(gameObject);
        }
    }
}