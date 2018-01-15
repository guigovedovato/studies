﻿using System.Collections.Generic;
using System.Linq;

namespace MyVersionCSharpDesignPatterns.Behavioral.Memento
{
    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();

        public Memento AddToken(int value)
        {
            return AddToken(new Token(value));
        }

        public Memento AddToken(Token token)
        {
            Tokens.Add(token);
            var m = new Memento();
            // a rather roundabout way of cloning
            m.Tokens = Tokens.Select(t => new Token(t.Value)).ToList();
            return m;
        }

        public void Revert(Memento m)
        {
            Tokens = m.Tokens.Select(mm => new Token(mm.Value)).ToList();
        }
    }
}
