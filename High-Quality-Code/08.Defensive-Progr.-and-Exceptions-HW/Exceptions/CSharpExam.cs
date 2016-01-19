using System;

public class CSharpExam : Exam
{
    public const int MinScoreCSharp = 0;
    public const int MaxScoreCSharp = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < MinScoreCSharp || MaxScoreCSharp < value)
            {
                throw new ArgumentOutOfRangeException("Score must be between 0 and 100.");
            }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, MinScoreCSharp, MaxScoreCSharp, "Exam results calculated by score.");
    }
}
