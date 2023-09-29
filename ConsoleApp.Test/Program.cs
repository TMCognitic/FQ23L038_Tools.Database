using ConsoleApp.Test.Models;
using ConsoleApp.Test.Models.Mappers;
using System.Data.SqlClient;
using Tools.Connections.Databases;

const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SampleDatabaseForTools;Integrated Security=True;Encrypt=False;";

//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();

//    Contact newContact = new Contact("Doe", "Jane", new DateTime(1970, 1, 1));
//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "INSERT INTO Contact (Nom, Prenom, Anniversaire) VALUES (@Nom, @Prenom, @Anniversaire);";
//        command.Parameters.AddWithValue("Nom", newContact.Nom);
//        command.Parameters.AddWithValue("Prenom", newContact.Prenom);
//        command.Parameters.AddWithValue("Anniversaire", newContact.Anniversaire);

//        Console.WriteLine($"Nombre de ligne affectée(s) : {command.ExecuteNonQuery()}");
//    }
//}

//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();
//    Contact newContact = new Contact("Doe", "Jane", new DateTime(1970, 1, 1));
//    Console.WriteLine($"Nombre de ligne affectée(s) : {connection.ExecuteNonQuery("CSP_AddContact", true, new { newContact.Nom, newContact.Prenom, newContact.Anniversaire })}");
//}

//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();

//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "SELECT Id, Nom, Prenom, Anniversaire FROM Contact;";

//        using (IDataReader reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                Console.WriteLine($"{reader["Id"]} : {reader["Nom"]} {reader["Prenom"]}");
//            }
//        }
//    }
//}

//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();

//    IEnumerable<Contact> contacts = connection.ExecuteReader("SELECT Id, Nom, Prenom, Anniversaire FROM Contact;", dr => dr.ToContact());
    
//    foreach (Contact contact in contacts)
//        Console.WriteLine($"{contact.Id} : {contact.Nom} {contact.Prenom}");
//}

//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();

//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "SELECT Id, Nom, Prenom, Anniversaire FROM Contact WHERE Id = @Id;";
//        command.Parameters.AddWithValue("Id", 1);

//        using (IDataReader reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                Console.WriteLine($"{reader["Id"]} : {reader["Nom"]} {reader["Prenom"]}");
//            }
//        }
//    }
//}

using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
{
    connection.Open();

    Contact? contact = connection.ExecuteReader("SELECT Id, Nom, Prenom, Anniversaire FROM Contact WHERE Id = @Id;", dr => dr.ToContact(), parameters: new { Id = 1 }).SingleOrDefault();

    if(contact is not null)
        Console.WriteLine($"{contact.Id} : {contact.Nom} {contact.Prenom}");
}

//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();

//    using (SqlCommand command = connection.CreateCommand())
//    {
//        command.CommandText = "SELECT COUNT(*) FROM Contact;";

//        int count = (int)command.ExecuteScalar();
//        Console.WriteLine($"Nombre de contacts : {count}");
//    }
//}


//using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
//{
//    connection.Open();
//    int? count = (int?)connection.ExecuteScalar("SELECT COUNT(*) FROM Contact;");
//    if (count.HasValue)
//        Console.WriteLine($"Nombre de contacts : {count}");
//}