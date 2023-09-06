using System;

namespace ProyectoIntroduccionGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(2600.42, 1200.24); // Crear objeto de tipo coche i por otro lado dar un estado inicial al coche1
            Coche coche2 = new Coche();



            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche1.getInfoCoche());



            coche1.setExtrasCoche(true, "Piel");
            coche2.setExtrasCoche(false, "Plastico");



            Console.WriteLine(coche1.getExtrasCoche());
            Console.WriteLine(coche2.getExtrasCoche());


        }
    }



    class Coche
    {

        public Coche() // Constructor para dar a todos los coches un estado inicial por defecto
        {
            ruedas = 4;

            longitud = 2300.5;

            ancho = 0.800;

        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;

            longitud = largoCoche;

            ancho = anchoCoche;
        }


        public String getInfoCoche()
        {
            return "Informacion del coche:\n" + "Ruedas: " + ruedas + "  Largo: " + longitud + "  Ancho: " + ancho;
        }



        public void setExtrasCoche(bool paramClimatizador, String tapiceria)
        {

            climatizador = paramClimatizador;

            this.tapiceria = tapiceria; // (this) para identificar cual es el parametro del metodo.

        }

        public String getExtrasCoche()
        {
            return "Informacion extras coche:\n" + "Climatizador: " + climatizador + " Tapiceria: " + tapiceria;
        }


        private int ruedas;
        private double longitud;
        private double ancho;

        private bool climatizador;
        private String tapiceria;





    }
}
