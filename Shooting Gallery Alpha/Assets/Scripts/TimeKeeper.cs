using System;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public float RoundTime = 20.5f;

    public static float TimeLeft = 0;

    public static event Action TimeIsUp;

    private void Start()
    {
        TimeLeft = RoundTime;
        Score.ResetScore();
    }

    private void Update()
    {
        TimeLeft -= Time.deltaTime;

        if (TimeLeft <= 0)
        {
            TimeLeft = 0;
            TimeIsUp?.Invoke();
            enabled = false;
        }
    }
}
