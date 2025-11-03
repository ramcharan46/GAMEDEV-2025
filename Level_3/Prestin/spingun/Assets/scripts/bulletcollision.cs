using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Collisiondetection : MonoBehaviour
{
    public Sprite damagedSprite;
    public float spinSpeed = 360f; 

    private SpriteRenderer spriteRenderer;
    private bool isSpinning = false; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        if (isSpinning)
        {
            
            transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            // --- Set the flag to start spinning ---
            isSpinning = true;
            
            // --- Original logic ---
            if (damagedSprite != null)
            {
                spriteRenderer.sprite = damagedSprite;
            }
            else
            {
                Debug.LogWarning("Damaged Sprite is not assigned in the Inspector!", this);
            }

            Destroy(other.gameObject);
            // --- End of original logic ---
        }
    }
}