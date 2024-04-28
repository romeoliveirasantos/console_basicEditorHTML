using System;
using System.Runtime.InteropServices;

namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      //Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;
      DrawScreen();
      WriteOptions();
      var Option = short.Parse(Console.ReadLine()!); 
      HandleMenuOption(Option);
    }
    public static void DrawScreen()
    {
      //int col -> numero de colunas
      TabelaSuperior(30);
      //int linhas e int colunas
      LinhasTabela(10, 30);
      //int col -> numero de colunas
      TabelaInferior(30);
    }
    public static void TabelaSuperior(int col)
    {
      Console.Write("+");
      for (int i = 0; i <= col; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");
    }
    public static void LinhasTabela(int linhas, int col)
    {
      for (int lines = 0; lines <= linhas; lines++)
      {
        Console.Write("|");

        for (int i = 0; i <= col; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }
    }
    public static void TabelaInferior(int col)

    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");
    }
    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("=================="); 
      Console.SetCursorPosition(3, 4);     
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 8);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 9);
      Console.Write("Opção: ");
      
    }
    public static void HandleMenuOption(short option)
    {
      switch(option)
      {
        case 1:
          Editor.Show();
          break;
        case 2:
          Console.WriteLine("View");
          break;
        case 0:{
          Console.Clear();
          Environment.Exit(0);
          break;
        }
        default:
          Show();
          break;
        
      }
    }


  }
}