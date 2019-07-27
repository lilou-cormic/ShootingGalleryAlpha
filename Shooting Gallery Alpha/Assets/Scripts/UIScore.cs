using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    private UINumber ThousandsNumber = null;
    [SerializeField]
    private UINumber HundredsNumber = null;
    [SerializeField]
    private UINumber TensNumber = null;
    [SerializeField]
    private UINumber UnitsNumber = null;

    private void Awake()
    {
        Score.ScoreChanged += Score_ScoreChanged;
    }

    private void OnEnable()
    {
        Score_ScoreChanged();
    }

    private void OnDestroy()
    {
        Score.ScoreChanged -= Score_ScoreChanged;
    }

    private void Score_ScoreChanged()
    {
        int score = Score.CurrentScore;

        int thousands = score / 1000;
        ThousandsNumber.SetNumber(thousands);
        score -= thousands * 1000;

        int hundreds = score / 100;
        HundredsNumber.SetNumber(hundreds);
        score -= hundreds * 100;

        int tens = score / 10;
        TensNumber.SetNumber(tens);
        score -= tens * 10;

        UnitsNumber.SetNumber(score);
    }
}
