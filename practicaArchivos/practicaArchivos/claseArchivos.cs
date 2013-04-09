using System;
using System.IO; 
namespace practicaArchivos
{
	public class claseArchivos
	{
		//Castillo Moreno Candy
		public  string archivo1="Archivo1.txt"; 
		public  string archivo2="Archivo2.txt";
		public  string archivo3="Archivo3.txt"; 
		public claseArchivos ()
		{}
	
	
		public void crearArchivos(){

			if(File.Exists(archivo1)|| File.Exists(archivo2)){

				Console.WriteLine("{0} \n {1} \n El archivo ya existe",archivo1,archivo2);
				return; 
				}
			  
			using(StreamWriter objeto = File.CreateText(archivo1)){

				objeto.WriteLine("\nLinea1"); 
				objeto.WriteLine("\nLinea2");
			
			
			}

			using(StreamWriter objeto2 = File.CreateText(archivo2)){

				objeto2.WriteLine("\nHola mundo");
				objeto2.WriteLine("\nTonala");
			}
		}
	
	
	public void leerArchivos(){

			if(!File.Exists(archivo1) || !File.Exists(archivo2)){


				Console.WriteLine("{0} \n {1} \n El archivo no existe",archivo1,archivo2);
				return; 

				}

			using(StreamReader objetoA = File.OpenText(archivo1)){

				String entrada; 
				while((entrada=objetoA.ReadLine())!=null){
					Console.WriteLine(entrada);
					}

				Console.WriteLine("\nFinal");
				objetoA.Close();
			}

			using(StreamReader objetoB = File.OpenText(archivo2)){
				
				String entrada2; 
				while((entrada2=objetoB.ReadLine())!=null){
					Console.WriteLine(entrada2);
				}
				
				Console.WriteLine("\nFinal");
				objetoB.Close();
			}

		 }
	
	  
		public void unir(){

			string texto; 
			string texto2; 
			StreamReader leer = File.OpenText (archivo1);
			StreamWriter escribe = new StreamWriter(archivo3);

			while((texto=leer.ReadLine())!=null){
				texto = leer.ReadLine(); 
				escribe.WriteLine(texto);
			
			}
			leer.Close (); 
			escribe.Close (); 
			StreamReader leer2 = File.OpenText (archivo2);
			StreamWriter escribe2 = File.AppendText(archivo3);
			
			while((texto2=leer2.ReadLine())!=null){
				texto2 = leer2.ReadLine(); 
				escribe2.WriteLine(texto2);
				
			}
			leer2.Close (); 
			escribe2.Close ();

		
		}


		}

	}


