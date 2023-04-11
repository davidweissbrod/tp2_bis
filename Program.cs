using System.Collections.Generic;

List<Boxeador> listaBoxeadores = new List <Boxeador>();
Console.WriteLine("1- Cargar Datos Boxeador 1");
Console.WriteLine("2- Cargar Datod Boxeador 2");
Console.WriteLine("3- Pelear!");
int opcion = Funciones.IngresarEnteroEnRango("Ingrese la opcion", 1, 4);
do
{
switch(opcion){
    case 1:
        IngresarBoxeador();
        break;
    case 2:
        IngresarBoxeador();
        break;
    case 3:
        Pelear();
        break;
    case 4:
        Console.WriteLine("Chau");
        break;
}
}while(opcion != 4)


void IngresarBoxeador(){
    nom.Boxeador = Funciones.IngresarTexto("Ingrese el nombre del boxeador");
    pais.Boxeador = Funciones.IngresarTexto("Ingrese el pais del boxeador");
    peso.Boxeador = Funciones.IngresarEntero("Ingrese el peso del boxeador");
    potGolpes.Boxeador = Funciones.IngresarEntero("Ingrese la potencia de los golpes del boxeador");
    velPiernas.Boxeador = Funciones.IngresarEntero("Ingrese la velocidad de las piernas del boxeador");
    listaBoxeadores.add(Boxeador);
    Console.WriteLine("Se creo al boxeador " + nom.Boxeador);
}

void Pelear(){
string nomBoxeadorGana;
double skillBoxeadorGana;
foreach(var boxeador in listaBoxeadores){
  if(skill.listaBoxeadores[0] > skill.listaBoxeadores[1]){
    if(listaBoxeadores[0].skill - listaBoxeadores[1].skill >= 30) Console.WriteLine("Gano el boxeador " + nom.listaBoxeadores[0] + " por KO"); 
    else if(listaBoxeadores[0].skill - listaBoxeadores[1].skill >= 10 && listaBoxeadores[0].skill - listaBoxeadores[1].skill < 30) 
    Console.WriteLine("Gano el boxeador " + nom.listaBoxeadores[0] + " por decision unanime");
    else if(listaBoxeadores[0].skill - listaBoxeadores[1].skill < 10) Console.WriteLine("Gano el boxeador " + nom.listaBoxeadores[0] + " por decision dividida");
  }
  else if(skill.listaBoxeadores[1] > skill.listaBoxeadores[0]){
    if(listaBoxeadores[1].skill - listaBoxeadores[0].skill >= 30) Console.WriteLine("Gano el boxeador " + nom.listaBoxeadores[1] + " por KO"); 
    else if(listaBoxeadores[1].skill - listaBoxeadores[0].skill >= 10 && listaBoxeadores[1].skill - listaBoxeadores[0].skill < 30) 
    Console.WriteLine("Gano el boxeador " + nom.listaBoxeadores[1] + " por decision unanime");
    else if(listaBoxeadores[1].skill - listaBoxeadores[0].skill < 10) Console.WriteLine("Gano el boxeador " + nom.listaBoxeadores[1] + " por decision dividida");
  }
  else Console.WriteLine("EMPATARON INCREIBLE");
}
}
