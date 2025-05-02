using UnityEngine;

public class FallDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController gameController = FindFirstObjectByType<GameController>();
            gameController.Defeat();
        }
    }

}
