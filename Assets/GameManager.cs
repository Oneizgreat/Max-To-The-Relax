using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int level;
    float score;
    public TextMeshProUGUI ScoreText;


    void Start()
    {
        level = 0;    
    }


    void Update()
    {
        score += (Random.value - 0.45f) * Time.deltaTime * 100; //svakih 3s update.
        int s = (int) score;
        ScoreText.text = s.ToString() ;
    }
}
