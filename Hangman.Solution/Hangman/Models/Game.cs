using System;
using System.Collections.Generic;

namespace Hangman.Models
{
    
  public class Game
  {
    public string Answer{get;}
    public List<Guess> guesses = new List<Guess>();
    public Game(string answer){
      Answer = answer;
    }

  }
}