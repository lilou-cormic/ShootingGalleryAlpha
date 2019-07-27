using UnityEngine;

public class UITime : MonoBehaviour
{
    [SerializeField]
    private UINumber HundredsNumber = null;
    [SerializeField]
    private UINumber TensNumber = null;
    [SerializeField]
    private UINumber UnitsNumber = null;

    private void Awake()
    {
        TimeKeeper.TimeIsUp += TimeKeeper_TimeIsUp;
    }

    private void Update()
    {
        int time = Mathf.FloorToInt(TimeKeeper.TimeLeft);

        int hundreds = time / 100;
        HundredsNumber.SetNumber(hundreds);
        time -= hundreds * 100;

        int tens = time / 10;
        TensNumber.SetNumber(tens);
        time -= tens * 10;

        UnitsNumber.SetNumber(time);
    }

    private void OnDestroy()
    {
        TimeKeeper.TimeIsUp -= TimeKeeper_TimeIsUp;
    }

    private void TimeKeeper_TimeIsUp()
    {
        HundredsNumber.SetNumber(0);
        TensNumber.SetNumber(0);
        UnitsNumber.SetNumber(0);

        enabled = false;
    }
}
