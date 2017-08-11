using System;
using System.Collections.Generic;

namespace RepeatFinder.Models
{
  public class Finder
  {
    private string _searchWord;
    private string _searchSentence;

    public Finder(string findWord, string sentence)
    {
      _searchWord = findWord;
      _searchSentence = sentence;
    }

    public int CountRepeats()
    {
      return 0;
    }
  }
}
