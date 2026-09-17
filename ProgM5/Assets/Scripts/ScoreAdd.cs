using TMPro;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;
    void OnEnable()
    {
        textField = GetComponent<TMP_Text>();
        DeathCheck.OnEnemyDeath += GetEnemyPoints;
    }

    void OnDisable()
    {
        DeathCheck.OnEnemyDeath -= GetEnemyPoints;
    }


    private void GetEnemyPoints()
    {
        score += 100;
        textField.text = "score: " + score;
    }
}
