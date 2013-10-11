using System;
using System.Collections;

namespace tareaa
{
	public class Practica3
	{
		public static void Main(string[] args)
		{

			Hashtable tabla=new Hashtable();
			
			for(int n=1;n<=2;n++){
	
	        Persona p=new Persona();
	        Console.WriteLine("Escribe un nombre");
            p.Nombre= Console.ReadLine();
            Console.WriteLine("Escribe un código");
            p.Codigo= int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un telefono");
            p.Telefono= Console.ReadLine();
            Console.WriteLine("");
            
            tabla.Add(p.Codigo,p);
			
			}
			
			for(int n=1;n<=2;n++){
				
			Console.WriteLine("Edite un código");
            Console.WriteLine("Código");
			int codigo= int.Parse (Console.ReadLine());
			
			Persona edit= (Persona)(tabla[codigo]);
			
			Console.WriteLine("Edite un nombre");
			Console.WriteLine("Nombre");
			edit.Nombre= Console.ReadLine();
            Console.WriteLine("Escriba el telefono");
            edit.Telefono= Console.ReadLine();
            Console.WriteLine("");
             
			}
			Console.Write("Presione enter para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}
