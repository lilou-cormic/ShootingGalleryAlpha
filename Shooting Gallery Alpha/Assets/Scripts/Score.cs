using System;

public static class Score
{
    public static int CurrentScore { get; private set; } = 0;

    public static event Action ScoreChanged;

    //TODO: High score
    
    //TODO: Multiplier

    public static void ChangeScore(int amount)
    {
        CurrentScore += amount;

        ScoreChanged?.Invoke();
    }

    public static void ResetScore()
    {
        CurrentScore = 0;

        ScoreChanged?.Invoke();
    }
}
