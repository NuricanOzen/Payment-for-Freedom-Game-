using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public GameObject losePanel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            LoseGame();
        }
    }

    public void LoseGame()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0f;
    }
}