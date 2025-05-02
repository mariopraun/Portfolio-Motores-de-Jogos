using UnityEngine;

public class Point : MonoBehaviour
{

    [SerializeField] int _point = 1;

    private GameController _gameController;
    void Start()
    {
        _gameController = FindFirstObjectByType<GameController>();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(_gameController != null)
            {
                _gameController.AddScore(_point);
            }
            Destroy(gameObject);
        }
    }

}
