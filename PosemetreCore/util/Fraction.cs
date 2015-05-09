using System;

namespace PosemètreCore.util
{
    public class Fraction
    {
        private int dénominateur;
        private int numérateur = 1;


        public Fraction(double valeureDécimale)
        {
            convertirEnFraction(valeureDécimale);
        }

        private void convertirEnFraction(double valeureDécimale)
        {
            double entier = Math.Truncate(valeureDécimale);
            double décimale = valeureDécimale - entier;

            double entier2 = Math.Truncate(décimale);
            double décimale2 = décimale - entier2;

            double entier3 = Math.Truncate(décimale2);
            double décimale3 = décimale2 - entier3;

            double entier4 = Math.Truncate(décimale3);
            double décimale4 = décimale3 - entier4;

            double entier5 = Math.Truncate(décimale4);
            double décimale5 = décimale4 - entier5;

            double entier6 = Math.Truncate(décimale5);
            double décimale6 = décimale5 - entier6;
        }




        public override string ToString()
        {
            return numérateur.ToString() + "/" + dénominateur.ToString();
        }

    }
}
