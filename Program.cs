using System;

namespace _18.OopPolymorphismTut
{
     //static or compilTime Polimorhism acheived by Methods  OverLoading
    public class Tutorial
    {
        public int TutorialID; //properties
        public string TutorialName;// declaring properties 

        public void SetTutorial(int pID, string pName) //Method 1
        {
            TutorialID = pID;  //setting both prpperties
            TutorialName = pName;
        }
        //method Overloading! -> methods with same name, but with differen paramets
        public void SetTutorial(string pName)  //Method 2 ; both method 1 and 2 have the same name but differen params;
        {
            TutorialName = pName; //setting just tutorial Name 
        }

        public string GetTutorial()
        {
            return TutorialName;
        }

        public int GetTutorialID()
        {
            return TutorialID;
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial(); //creating an Object of Tutorial Class ! 

            pTutor.SetTutorial( 1 , "First Tutorial");  //method called on Object with 2 params
            Console.WriteLine(pTutor.GetTutorial());

            pTutor.SetTutorial("Second Tutorial"); //method called on object with one params seting a new value ! 
            Console.WriteLine(pTutor.GetTutorial());

            Console.WriteLine(pTutor.GetTutorialID());
        }
    }
}
