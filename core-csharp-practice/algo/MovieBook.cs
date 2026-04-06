using System;

class MovieBook
{
    private Movie[] movies;
    private int count;
    private int capacity;

    public MovieBook()
    {
        capacity = 2;
        movies = new Movie[capacity];
        count = 0;
    }

    public void AddMovie(string title, string time)
    {
        if (count == capacity)
        {
            capacity *= 2;
            Movie[] newMovies = new Movie[capacity];
            for (int i = 0; i < count; i++)
                newMovies[i] = movies[i];
            movies = newMovies;
        }
        movies[count++] = new Movie(title, time);
        Console.WriteLine("Movie added successfully!\n");
    }

    public void DisplayAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No movies available.\n");
            return;
        }

        Console.WriteLine("All movies:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine((i + 1) + ". " + movies[i].GetMovieInfo());
        }
        Console.WriteLine();
    }

    public void SearchMovie(string keyword)
    {
        bool found = false;
        Console.WriteLine("Search results for '" + keyword + "':");
        for (int i = 0; i < count; i++)
        {
            if (movies[i].Title.ToLower().Contains(keyword.ToLower()))
            {
                Console.WriteLine((i + 1) + ". " + movies[i].GetMovieInfo());
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("No movies found.\n");
    }
}

class Movie
{
    public string Title { get; set; }
    public string ShowTime { get; set; }

    public Movie(string title, string showTime)
    {
        Title = title;
        ShowTime = showTime;
    }

    public string GetMovieInfo()
    {
        return Title + " - " + ShowTime;
    }
}
