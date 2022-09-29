Imports MySql.Data.MySqlClient

Module Function_List
    Public con As New MySqlConnection("Server=localhost; User Id=root; Password=admin; Database=his_database")
    Public cmd1 As MySqlCommand
    Public cmd2 As MySqlCommand
    Public cmd3 As MySqlCommand
    Public cmd4 As MySqlCommand
    Public cmd5 As MySqlCommand

    Public adapter As MySqlDataAdapter

    Public insertorupdate As Integer '1 = insert    2 = update
    Public reservationID As Integer

End Module
