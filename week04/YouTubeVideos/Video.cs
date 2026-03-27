using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length; 
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public int GetCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine("Video: " + _title);
        Console.WriteLine("By: " + _author + " (" + _length + " seconds)");
        Console.WriteLine("Comments (" + GetCount() + "):");

        foreach (var comment in _comments)
        {
            Console.WriteLine("- " + comment._name + ": " + comment._text);
        }
        
        Console.WriteLine("------------------------------");
    }
}