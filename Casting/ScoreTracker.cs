namespace cse210_04.Game.Casting;
public class ScoreTracker : Actor
{
    // Initializing Score and Multiplier Variables
    private int Score = 0;
    private int Multiplier = 1;

    // Method GetScore:
    // Responsiblity: Getter for the current score
    // Parameters: None
    // Returns: Score
    public int GetScore()
    {
        return Score;
    }
    // Method GetMultiplier:
    // Responsiblity: Getter for the current multiplier
    // Parameters: None
    // Returns: Multiplier
    public int GetMultiplier()
    {
        return Multiplier;
    }
    // Method UpdateScore:
    // Responsibility: Determines the new score based on the hit item's point value and the current multiplier.
    // Parameters: ItemScore: point value of the hit item
    // Returns: None
    public void UpdateScore(int ItemScore)
    {
        Score += (ItemScore * Multiplier);
    }
    // Method UpdateMultiplier:
    // Responsibility: Determines the new multiplier based on the hit item's multiplier value.
    // Parameters: ItemMultiplier: point value of the hit item
    // Returns: None
    public void UpdateMultiplier(int ItemMultiplier)
    {
        if (ItemMultiplier == -1)
        {
            Multiplier = 1;
        }
        else
        {
            Multiplier += ItemMultiplier;
        }
    }

}