using System;
using System.Collections.Generic;

namespace RepeatFinder.Models
{
  public class RepeatCounter
  {
    private string _searchWord;
    private string _searchSentence;
    private char[] _punctuation = new char[] {' ', '\'', '\"', ',', '.', '!', '?', '/', '(', ')', '[', ']'};

    public RepeatCounter(string findWord, string sentence)
    {
      _searchWord = findWord;
      _searchSentence = sentence;
    }

    public string GetSentence()
    {
      return _searchSentence;
    }

    public string GetWord()
    {
      return _searchWord;
    }

    public int CountRepeats()
    {
      String[] brokenSentence = _searchSentence.Split(_punctuation);
      int timesRepeated = 0;
      for (int i = 0; i < brokenSentence.Length; i++)
      {
        if (this.WordMatches(brokenSentence[i]))
        {
          timesRepeated += 1;
        }
      }
        return timesRepeated;
    }

    public bool WordMatches(string wordToCheck)
    {
      return (_searchWord.ToLower() == wordToCheck.ToLower());
    }
  }
}
