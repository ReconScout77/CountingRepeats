using System;
using System.Collections.Generic;

namespace RepeatFinder.Models
{
  public class RepeatCounter
  {
    private string _searchWord;
    private string _searchSentence;

    public RepeatCounter(string findWord, string sentence)
    {
      _searchWord = findWord;
      _searchSentence = sentence;
    }

    public string GetSentence()
    {
      return _searchSentence;
    }

    public int CountRepeats()
    {
      int timesRepeated = 0;
      if (this.WordMatches(_searchSentence))
      {
        timesRepeated += 1;
      }
      return timesRepeated;
    }

    public bool WordMatches(string wordToCheck)
    {
      return (_searchWord == wordToCheck);
    }
  }
}
