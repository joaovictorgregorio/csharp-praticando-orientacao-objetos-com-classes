namespace MovieAccessValidation;

public class Movie
{
    public Movie(string title, int ageClassification)
    {
        Title = title;
        AgeClassification = ageClassification;
    }

    public string Title { get; set; }
    public int AgeClassification { get; set; }

    public bool YouCanWatch(int userAge) => userAge >= AgeClassification;

    public void DisplayResult(int userAge) => Console.WriteLine(
        YouCanWatch(userAge)
            ? $"  Usuário com {userAge} anos pode assistir ao filme {Title}."
            : $"  Usuário com {userAge} anos não pode assistir ao filme {Title}."
    );
}
