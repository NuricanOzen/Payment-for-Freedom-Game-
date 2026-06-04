using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winPanel; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           if (collision.TryGetComponent(out PlayerInventory inventory))
            {
                if (inventory.keyCount > 1)
                {
                    Debug.Log("CONGRATULATIONS! You escaped death!");
                    winPanel.SetActive(true);
                    Time.timeScale = 0f; 
                }
                else
                {
                    Debug.Log("LOCKED! You need 2 keys. Current keys: " + inventory.keyCount);
                }
            }
        }
    }
}