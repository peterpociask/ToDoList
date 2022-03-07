using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool  isChecked {get;set;}
    }
}