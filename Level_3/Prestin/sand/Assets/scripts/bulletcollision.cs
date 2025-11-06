using UnityEngine;

public class Collisiondetection : MonoBehaviour
{
   
    public Sprite damagedSprite;

   
    private SpriteRenderer spriteRenderer;

    void Start()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();

       
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on the GameObject!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Bullet"))
        {
            
            Destroy(other.gameObject);

            
            if (spriteRenderer != null && damagedSprite != null)
            {
                spriteRenderer.sprite = damagedSprite;
            }

           
        }
    }
}