using System;
using Microsoft.VisualBasic;

namespace Services
{
    
    // solution will be defined for 3 parts:
    // first - interfaces for main parts
    // second - logic that will work with mind cards
    // third -  new project with view and interface implementations;
    
    public class FirstImplementation
    {
        public FirstImplementation()
        {
            //opendatabase
        }
        
        
        public void CreateCard()
        {
            
        }

        public void GetCard()
        {
            
        }
    }

    public class Card
    {
        private int Id { get; set; }
        private int Level { get; set; }
        private string Theme { get; set; }
        private string Body { get; set; }


        public Card(string theme, string body)
        {
            Id = new Random().Next();
            Level = 0;
            Theme = theme;
            Body = body;
        }

        public void ChangeTheme(string newTheme)
        {
            Theme = newTheme;
        }

        public void ChangeBody(string newBody)
        {
            Body = newBody;
        }

        public void LevelUp()
        {
            if (Level <= 5) Level++;
            if (Level == 5) this.Delete();
        }

        public void LevelDown()
        {
            if (Level > 1) Level--;
        }

        protected virtual void Delete()
        {
            
        }
    }
}