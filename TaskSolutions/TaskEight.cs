﻿using DatabaseSimulation;
using System.Collections.Generic;

namespace TaskSolutions
{
    public class TaskEight
    {
        List<TaskEightDatabase> databaseObject = new List<TaskEightDatabase>();

        public TaskEight()
        {
                
        }

        public int AddNewBook()
        {
            return 1;
        }

        public List<string> DisplayBookDetails()
        {
            return null;
        }

        public string SearchBookByTitle(string title)
        {
            return "title";
        }

        public string DeleteBookByID(int id)
        {
            //query id here
            if (id!=0)            
                return "found";
            
            else
            {
                return "book not found or available";
            }
        }

        //options method here
        //to allow users to 
        //choose options
        //preferably a switch 
        //statement
    }

}
