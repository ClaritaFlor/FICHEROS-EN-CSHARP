/*
 * Created by SharpDevelop.
 * User: clarita
 * Date: 7/23/2018
 * Time: 10:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.IO;
namespace Ficheros
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Leyendo desde un archivo usando BufferedStream
			Console.WriteLine("Leyendo desde un archivo usando BufferedStream");
			string path = "C:\\EJEMPLOS\\fichero.txt";
			Stream instream = File.OpenRead(path);

			// crear buffer para abrir stream
			BufferedStream bufin = new BufferedStream(instream); 
			byte[] bytes = new byte[128];

			// leer los primeros 128 bytes del archivo
			bufin.Read(bytes, 0, 128);
			Console.WriteLine("Mostrando bytes: " + Encoding.ASCII.GetString(bytes));
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			//Leyendo desde un archivo de texto
			Console.WriteLine("Leyendo desde un archivo de texto");
			string fileName = "fichero.txt";
			FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			StreamReader reader = new StreamReader(stream);

			while (reader.Peek() > -1)
				Console.WriteLine(reader.ReadLine());
			reader.Close();
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			//Escribiendo un archivo
			Console.WriteLine("Escribiendo un archivo123");
			string fileName1 = "fichero.txt";
    		FileStream stream1 = new FileStream(fileName1, FileMode.OpenOrCreate, FileAccess.Write);
    		StreamWriter writer = new StreamWriter(stream1);

   			 writer.WriteLine("Esta es la primera línea del archivo.12312345 hola como estas");
   			 writer.Close();
   			 
   			 Console.WriteLine("Press any key to continue . . . ");
			 Console.ReadKey(true);
			 
			 //Escribiendo y creando archivo
			 Console.WriteLine("Escribiendo y creando un archivo");
			 string fileName2 = "temp1.txt";
   			 StreamWriter writer2 = File.CreateText(fileName2);

  			  writer2.WriteLine("Este es mi Nuevo archivo creado.");
  			  writer2.Close();
  			  
  			  Console.WriteLine("Press any key to continue . . . ");
			 Console.ReadKey(true);
			 
			 //Insertando texto en un archivo
			 Console.WriteLine("Insertando texto en un archivo");
			 try
   			 {
     		   string fileName3 = "temp1.txt";
    	    // esto inserta texto en un archivo existente, si el archivo no existe lo crea
    		    StreamWriter writer3 = File.AppendText(fileName3);
    		    writer3.WriteLine("Este es el texto adicionado LAB 121.");
    		    writer3.Close();
   			 }
  			  catch
  			  {
  		      Console.WriteLine("Error");
   			 }
  			  
  			  Console.WriteLine("Press any key to continue . . . ");
			 Console.ReadKey(true);
  			  //archivo binario
			 Console.WriteLine("archivo binario ");
  			  try
    {
        string fileName4 = "temp1.txt";
        int letter = 0;
        FileStream stream4 = new FileStream(fileName4, FileMode.Open, FileAccess.Read);
        BinaryReader reader4 = new BinaryReader(stream4);

        while (letter != -1)
        {
            letter = reader4.Read();
            if (letter != -1) Console.Write((char)letter);
        }
        reader4.Close();
        stream4.Close();
  	  }
   		 catch
    	{
       		 Console.WriteLine("Error");
   	 	}
    		Console.WriteLine("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
		
	}
}