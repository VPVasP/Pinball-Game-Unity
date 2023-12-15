using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI pointsText;
    [SerializeField] private float points;
    private string pointsString = "Points ";
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        pointsText.text = pointsString + points.ToString();
    }
    public void AddRandomPoints()
    {
        float randomPoints = Random.Range(1, 11);
        points += randomPoints;
        pointsText.text = pointsString + points.ToString();
    }
  
}
