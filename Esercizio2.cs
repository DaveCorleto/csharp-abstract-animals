using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    //    ** Esercizio 2 : interfacce**
    //Alcuni degli animali che abbiamo creato volano, altri nuotano.
    //Gli animali che volano hanno il seguente metodo :
    //- void Vola() (mostra a video “Sto volando!!!”)
    //Gli animali che nuotano hanno il seguente metodo :
    //- void Nuota() (mostra a video “Sto nuotando!!!”)
    //Scrivere un programma avente 2 metodi :
    //- void FaiVolare(IVolante animale)
    //- void FaiNuotare(INuotante animale)
    //Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
    //Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.

    //public interface IAnimalieBasta 
    //{
    //    void FaiVolare(IAnimalecheVolano);
    //    void FaiNuotare(IAnimalicheNuotano);


   

    public interface IAnimalicheVolano 
    {
        public void Vola();
    }

    public interface IAnimalicheNuotano {       
        public void Nuota();
    }

}
