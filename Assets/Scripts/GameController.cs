using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    [SerializeField] int _totalScore = 0;
    [SerializeField] int _pointsToWin = 10;
    [SerializeField] GameObject _endGame;
    [SerializeField] TMP_Text _scoreText;
    [SerializeField] TMP_Text _endGameText;
    [SerializeField] Color _colorVictory = Color.green;
    [SerializeField] Color _colorDefeat = Color.red;
        

    public void UpdateScoreText()
    {
        if(_scoreText != null)
        {
            _scoreText.text = "Moedas: " + _totalScore.ToString() + "/" + _pointsToWin.ToString();
        }
    }

    public void AddScore(int points)
    {
        _totalScore += points;
        UpdateScoreText();
        if(_totalScore >= _pointsToWin)
        {
            EndGame("VOCÊ VENCEU!!!", _colorVictory);
        }
    }

    public void Defeat()
    {
        EndGame("VOCÊ PERDEU!!!", _colorDefeat);
    }

    void EndGame(string message, Color textColor) 
    {
        if(_endGame != null)
        {
            _endGame.gameObject.SetActive(true);
            _endGameText.text = message;
            _endGameText.color = textColor;
            Time.timeScale = 0f;
        }
    }

    private void Start()
    {
        if(_endGame != null)
        {
            _endGame.gameObject.SetActive(false);
        }

        UpdateScoreText();
        Time.timeScale = 1f;
    }
}
