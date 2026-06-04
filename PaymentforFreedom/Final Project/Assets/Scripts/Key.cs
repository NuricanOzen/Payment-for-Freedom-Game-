using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           if (collision.TryGetComponent(out PlayerInventory inventory))
            {
                inventory.keyCount++;
                Destroy(gameObject); 
            }
        }
    }
}