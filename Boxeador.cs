class Boxeador{
public string nombre {get; set;}
public string PAIS{get; set;}
public int PESO{get; set;}
public int potenciaGolpes{get; set;}
public int velocidadPiernas{get; set;}


public Boxeador(string nom, string pais, int peso, int potGolpes, int velPiernas){
    nombre = nom;
    pais = PAIS;
    peso = PESO;
    velPiernas = velocidadPiernas;
    potGolpes = potenciaGolpes;
}

public double ObtenerSkill(){
    double skill = velPiernas * 0.6 + potGolpes * 0.8 + Random();
    return skill;
}

public Random(){
    Random rnd = new Random();
    return rnd.Next(1, 10 + 1);
}
}