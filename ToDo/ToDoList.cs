using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ToDoList 
{
    private string selectedItem;
    public ObservableCollection<string> MyToDoList { get; set; }
    
    public string SelectedItem
    {
        get => selectedItem;
        set
        {
            selectedItem = value;
        }
    }
    
    public ToDoList()
    {
        MyToDoList = new ObservableCollection<string>
            {
                "Test 1",
                "Test 2",
                "Test 3",
                "Test 4",
                "Test 5",
                "Test 6",
                "Test 7",
                "Test 8",
                "Test 9",
                "Test 10"
            };
    }

    public void AccessToDo(string text)
    {
        if (MyToDoList.Contains(text))
        {
            MyToDoList.Remove(text);
        }
        else
        {
            MyToDoList.Add(text);
        }
    }
    
    public void CompletedTask(string text)
    {
        
        if (MyToDoList.Contains(text))
        {
            int index = MyToDoList.IndexOf(text);
            MyToDoList[index] = text + " (Completed)";
            SelectedItem = MyToDoList[index];
        }
        
    }
}

