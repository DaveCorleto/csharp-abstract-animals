using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_abstract_animals
{
    //    ** Esercizio 1 : classi astratte**
    //Dobbiamo realizzare un programma che rappresenti il regno animale.
    //Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
    //Vogliamo che gli animali abbiano i seguenti metodi
    //- void Dormi() (mostra a video “Zzz”)
    //- void Verso() (mostra a video il verso fatto dall'animale specifico)
    //- void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
    //Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
    //Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
    public abstract class Animale {  


    public string razza { get; set; }
    public string nome { get; set; }
    public int età { get; set; }

    public Animale (string razza, string nome, int età)
    {
        this.razza = razza;
        this.nome = nome;
        this.età = età;
    }

    public abstract void Dormi();
        public abstract void Verso();
        public abstract void Mangia();

       
    }
    public class Cane : Animale {

        public string verso { get; } = "Bau!";

        public Cane(string razza, string nome, int età) :base(razza,nome,età){ 

        }
        public override  void Dormi()
        {
            Console.WriteLine("Sono un cane e sto dormendo...ZzZzZzZzZ");
        }
        public override  void Verso()
        {
            Console.WriteLine(verso);
        }
        public override void Mangia()
        {
            Console.WriteLine("Sono un cane e sto mangiando una bistecca!");
        }
    }

    public class Passerotto : Animale {

        public Passerotto (string razza, string nome, int età) : base(razza, nome, età)
        {

        }

        public string verso = "Cip!";
        public override void Dormi()
        {
            Console.WriteLine("Sono un passerotto e sto dormendo...ZzZzZzZzZ");
        }
        public override void Verso()
       {
            Console.WriteLine(verso);
       }
       public override void Mangia()
        {
            Console.WriteLine("Sono un passerotto e sto maniando dei semini!");
        }

    }

    public class Aquila : Animale {    

           public Aquila(string razza, string nome, int età) : base(razza, nome, età)
        {

        }
    
        public string verso = "CRZVDSILJSPIIIIIIIII!";
        public override void Dormi()
        {
            Console.WriteLine("Sono un aquila e sto dormendo...ZzZzZzZzZ");
        }
        public override void Verso()
        {
            Console.WriteLine(verso);
        }
        public override void Mangia()
        {
            Console.WriteLine("Sono un aquila e sto mangiando un castoro!");
        }
    }

    public class Delfino : Animale
    {
        public Delfino (string razza, string nome, int età) : base(razza, nome, età)
        {

        }

        public string verso = "Hik hik!";
        public override void Dormi()
        {
            Console.WriteLine("Sono un Delfino e sto dormendo...ZzZzZzZzZ");
        }
        public override void Verso()
        {
            Console.WriteLine(verso);
        }
        public override void Mangia()
        {
            Console.WriteLine("Sono un Delfino e sto mangiando del pesce!");
        }
    }
}
