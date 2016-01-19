using System;

public class SimpleMathExam : Exam
{
    public const int ProblemsCountMathExam = 10;
    private const string ExcellentGradeComment = "Excellent result: you're a star. Nerd :)";
    private const string GoodGradeComment = "Good result: good effort!";
    private const string AverageGradeComment = "Average result: keep trying!";
    private const string BadGradeComment = "Bad result: nothing done.";
    private const int BadGradeProblemsSolved = 2;
    private const int AverageGradeProblemsSolved = 5;
    private const int GoodGradeProblemsSolved = 8;
    private int problemsSolved = 0;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if (value < 0 || value > ProblemsCountMathExam)
            {
                throw new ArgumentException("Solved problems cannot be less than 0 or more than 10.");
            }
            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        string comment;
        if (this.ProblemsSolved <= BadGradeProblemsSolved)
        {
            comment = BadGradeComment;
        }
        else if (this.ProblemsSolved <= AverageGradeProblemsSolved)
        {
            comment = AverageGradeComment;
        }
        else if (this.ProblemsSolved <= GoodGradeProblemsSolved)
        {
            comment = GoodGradeComment;
        }
        else 
        {
            comment = ExcellentGradeComment;
        }

        return new ExamResult(this.ProblemsSolved, 0, ProblemsCountMathExam, comment);
    }
}
