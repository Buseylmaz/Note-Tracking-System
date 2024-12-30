using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace NoteTrackingSystem
{
    // data extraction list, collection, update and deletion operations are performed in this class.
    public class NoteDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Notes;integrated security=true;");

        void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        //List
        public List<Note> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Notes", _connection);

            SqlDataReader reader= command.ExecuteReader();

            List<Note> notes = new List<Note>();

            while (reader.Read())
            {
                Note note = new Note
                {
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    StudentNameSurname = reader["StudentNameSurname"].ToString(),
                    Mathematics = Convert.ToInt32(reader["Mathematics"]),
                    Turkish = Convert.ToInt32(reader["Turkish"]),
                    PhysicalEducation = Convert.ToInt32(reader["PhysicalEducation"]),
                    Music = Convert.ToInt32(reader["Music"])
                };

                notes.Add(note);
            }

            reader.Close();
            _connection.Close();
            return notes;
        }


        //Added
        public void Add(Note note)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Notes values(@studentNameSurname,@mathematics,@turkish,@physicalEducation,@music)", _connection);

            command.Parameters.AddWithValue("@studentNameSurname", note.StudentNameSurname);
            command.Parameters.AddWithValue("@mathematics", note.Mathematics);
            command.Parameters.AddWithValue("@turkish", note.Turkish);
            command.Parameters.AddWithValue("@physicalEducation", note.PhysicalEducation);
            command.Parameters.AddWithValue("@music", note.Music);

            command.ExecuteNonQuery();
            _connection.Close();

        }


        //Update
        public void Update(Note note)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Notes set StudentNameSurname=@studentNameSurname,Mathematics=@mathematics,Turkish=@turkish,PhysicalEducation=@physicalEducation,Music=@music where StudentID=@studentID", _connection);


            command.Parameters.AddWithValue("@studentNameSurname", note.StudentNameSurname);
            command.Parameters.AddWithValue("@mathematics", note.Mathematics);
            command.Parameters.AddWithValue("@turkish", note.Turkish);
            command.Parameters.AddWithValue("@physicalEducation", note.PhysicalEducation);
            command.Parameters.AddWithValue("@music", note.Music);
            command.Parameters.AddWithValue("@studentID", note.StudentID);

            command.ExecuteNonQuery();
            _connection.Close();

        }


        //Delete
        public void Delete(int studentId)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Notes where StudentID=@studentID", _connection);

            command.Parameters.AddWithValue("@StudentID", studentId);

            command.ExecuteNonQuery();
            _connection.Close();

        }
    }
}
