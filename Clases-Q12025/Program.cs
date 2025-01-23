
using Clases_Q12025;

Ave ave = new Ave();
ave.Familia.Nombre = "Psittaciade";
ave.Familia.NumeroEspecie = 393;
ave.Familia.Caracteristicas = "Aves Coloridas";
ave.Nombre = "Loro";
ave.Especie = "Amazona eastiva";
ave.Color = "Verde";
ave.Tamano = 30.5;
ave.Habitat = "Bosques Tropicales";
ave.Imprimir();

Ave ave2 = new Ave();
ave2.Nombre = "Flamenco";
ave2.Especie = "Phoenicopterus roseus";
ave2.Color = "Rosa";
ave2.Tamano = 120;
ave2.Habitat = "Lagunas Salinas";
ave2.Familia.Nombre = "Phoenicopteridae";
ave2.Familia.NumeroEspecie = 6;
ave2.Familia.Caracteristicas = "Aves zancudas";
ave2.Imprimir();