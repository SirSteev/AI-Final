using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LaMountain_AI_Final
{
    class Chromosome
    {
        Gene[] genes;
        public Random prng = new Random();
        const float mutationRateDefault = 0.1f;
        float mutationRate = mutationRateDefault;
        int fitness;

        public int Fitness
        {
            get { return fitness; }
        }

        public Chromosome(int length)
        {
            genes = new Gene[length];

            for (int i = 0; i < length; i++)
            {
                int val = prng.Next(0, 256);

                genes[i] = new Gene(val);
            }
            fitness = int.MaxValue;
        }
        public Chromosome(Chromosome template)
        {
            genes = new Gene[template.GetChromosomeLength()];

            for (int i = 0; i < template.GetChromosomeLength(); i++)
            {
                genes[i] = new Gene(prng.Next(0, 256));
                genes[i].SetColor(template.GetGeneByIndex(i).GeneColor);
            }
            fitness = int.MaxValue;
        }

        public int CalcFitness(Bitmap image)
        {
            if (fitness == int.MaxValue)
            {
                fitness = 0;
                for (int i = 0; i < genes.Length; i++)
                {
                    fitness += genes[i].CalcFitnessValue(image.GetPixel(i % image.Width, i / image.Width).R);
                }
            }
            return fitness;
        }

        public Gene GetGeneByIndex(int ndx)
        {
            return genes[ndx];
        }

        public void SetGeneByIndex(int ndx, Gene gene)
        {
            genes[ndx].SetColor(gene.GeneColor);
        }

        public int GetChromosomeLength()
        {
            return genes.Length;
        }

        public void MutateGeneAtIndex(int ndx, int variationAmount)
        {
            int mutation = prng.Next(0, variationAmount * 2 + 1);
            
            mutation -= variationAmount;
            mutation += genes[ndx].GeneColor;
            
            if (mutation > 255) mutation = 255;
            if (mutation < 0) mutation = 0;

            //int mutation = prng.Next(0, 256);

            genes[ndx].SetColor(mutation);
        }

        internal void Mate(Chromosome mother, out Chromosome child1, out Chromosome child2)
        { 
            child1 = new Chromosome(mother); // equate child to mother
            child2 = new Chromosome(this); // equate child to father

            //int pos = prng.Next(0, genes.Length - 2);
            //
            //for (int i = pos; i < genes.Length; i++) // mingle
            //{
            //    child1.SetGeneByIndex(i, genes[i]);
            //    child2.SetGeneByIndex(i, mother.GetGeneByIndex(i));
            //}
            
            int rgb;
            
            for (int i = 0; i < genes.Length; i++) // blend between two points
            {
                rgb = prng.Next(0, 2);
                switch (rgb)
                {
                    case 0:
                        child1.SetGeneByIndex(i, genes[i]);
                        break;
                    case 1:
                        child1.SetGeneByIndex(i, mother.GetGeneByIndex(i));
                        break;
                    default:
                        break;
                }

                rgb = prng.Next(0, 2);
                switch (rgb)
                {
                    case 0:
                        child2.SetGeneByIndex(i, mother.GetGeneByIndex(i));
                        break;
                    case 1:
                        child2.SetGeneByIndex(i, genes[i]);
                        break;
                    default:

                        break;
                }
            }

            double test = prng.NextDouble();
            if (test <= mutationRate)
            {
                child1.MutateRandomGeneBy(10);
            }

            test = prng.NextDouble();
            if (test <= mutationRate)
            {
                child2.MutateRandomGeneBy(10);
            }
        }

        private void MutateRandomGeneBy(int variationAmount)
        {
            int mutation = prng.Next(0, variationAmount * 2 + 1);

            int ndx = prng.Next(0, genes.Length);

            mutation -= variationAmount;
            mutation += genes[ndx].GeneColor;

            if (mutation > 255) mutation = 255;
            if (mutation < 0) mutation = 0;

            //int mutation = prng.Next(0, 256);

            genes[ndx].SetColor(mutation);
        }
    }
}
