using System;
class Aula03{
    static void Main(){
        /* VARIÁVEIS LOCAIS AO MÉTODO MAIN */
        byte n1 = 10;   // valor entre 0 e 255.
        int n2 = 0;
        char letra = 'n';
        float altura = 1.67f;
        String nome = "Nilton";
        String cachorro1, cachorro2, cachorro3, cachorro4;
        cachorro1 = "Madruguinha";
        cachorro2 = "Atena";
        cachorro3 = "Apolo";
        cachorro4 = "Florinda";

        /* Posso usar VAR, assim eu não especifico o tipo da variável. Porém, o C# detecta automaticamente o tipo na hora da compilação. Uma vez atribuido o valor da uma variável com VAR, não posso mais mudar seu valor, pois o compilador vai dar um tipo pra ela. */
        var auxiliar1 = 0;
        var auxiliar2 = "Silva";

        Console.WriteLine(auxiliar1);
        Console.WriteLine(auxiliar2);
        Console.WriteLine("Nílton " + auxiliar2 + " Ferreira");
        Console.WriteLine("Meus cachorros são: " + cachorro1 + ", " + cachorro2 +", "+ cachorro3 + ", " + cachorro4 + ".");
    }
}