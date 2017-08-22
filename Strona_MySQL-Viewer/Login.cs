using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace Strona_MySQL_Viewer
{
    public class Login
    {
        MySqlConnection connection;

        public bool OpenConnection(WebForm1 a, string Data) {
            try
            {
                a.setStatus("Łączenie...");
                Console.WriteLine("Pierwsze polaczenie");
                connection = new MySqlConnection(Data);
                connection.Open();
                a.setStatus("Połączono :D");
                return true;


            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Number);
                Console.WriteLine(ex.ErrorCode);
                Console.WriteLine(ex.Message);
                switch (ex.ErrorCode)
                {
                    case -2147467259:
                        switch (ex.Number)
                        {
                            case 1042:
                                //Brak połączenia z serwerem
                                a.setStatus($"Nie odnaleziono serwera MySQL na {connection.DataSource}. Sprawdź adres serwera i połączenie internetowe");
                                break;
                            case 0:
                                if (ex.Message[0] == 'T')
                                {
                                    a.setStatus("Przekroczono czas połączenia. Sprawdź połączenie internetowe.");
                                }
                                else
                                {
                                    //Zły login/hasło
                                    a.setStatus("Błędny login, hasło i/lub baza danych.");
                                }
                                break;
                            default:
                                //Inny błąd
                                a.setStatus($"Nieznany błąd: {ex.Number}${ex.ErrorCode}.");
                                break;
                        }
                        break;
                    default:
                        //Inny błąd
                        a.setStatus($"Nieznany błąd: {ex.Number}${ex.ErrorCode}.");
                        break;
                }
                return false;
            }
        }
    }
}