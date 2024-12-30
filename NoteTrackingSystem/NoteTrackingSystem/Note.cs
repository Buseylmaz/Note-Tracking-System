using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTrackingSystem
{
    public class Note
    {
        //veri tabanında ki özellikleri bu class içinde yazarız
        public int StudentID { get; set; }
        public string StudentNameSurname { get; set; }
        public int Mathematics { get; set; }
        public int Turkish { get; set; }
        public int PhysicalEducation { get; set; }
        public int Music { get; set; }
    }
}
