using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NoteTrackingSystem
{
    //veri çekme listelem ekleme ve silme işlemleri için yapılacak yer
    public class NoteDal
    {
        //LİSTELEME
        public List<Note> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Notes;integrated security=true;");

            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Select * from Notes", connection);

            SqlDataReader reader= command.ExecuteReader();

            List<Note> notes = new List<Note>();

            while (reader.Read())
            {
                Note note = new Note
                {
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    StudentNameSurname = reader["Student Name Surname"].ToString(),
                    Mathematics = Convert.ToInt32(reader["Mathematics"]),
                    Turkish = Convert.ToInt32(reader["Turkish"]),
                    PhysicalEducation = Convert.ToInt32(reader["Physical Education"]),
                    Music = Convert.ToInt32(reader["Music"])
                };

                notes.Add(note);
            }

            reader.Close();
            connection.Close();
            return notes;
        }
    }
}
