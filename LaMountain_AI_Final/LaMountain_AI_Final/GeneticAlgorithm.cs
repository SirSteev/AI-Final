using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LaMountain_AI_Final
{
    class GeneticAlgorithm
    {
        Chromosome[] population;
        Bitmap imageToMatch;
        int generationNum;
        int eleitism = 5;
        const int POP_SIZE = 500;

        public int Generation
        {
            get { return generationNum; }
        }

        public GeneticAlgorithm(Bitmap image)
        {
            imageToMatch = image;

            population = new Chromosome[POP_SIZE];

            for (int i = 0; i < POP_SIZE; i++)
            {
                population[i] = new Chromosome(image.Width * image.Height); // chromosome length is image width * image height
            }
            generationNum = 0;
            CalcFitnesses();
        }

        public void CalcFitnesses()
        {
            for (int i = 0; i < POP_SIZE; i++)
            {
                population[i].CalcFitness(imageToMatch);
            }

            bool isSorted = false;

            while (!isSorted) // sorts population by fitness score
            {
                Chromosome temp = null;

                for (int i = 0; i < POP_SIZE - 1; i++)
                {
                    if (population[i].Fitness > population[i + 1].Fitness)
                    {
                        temp = population[i];
                        population[i] = population[i + 1];
                        population[i + 1] = temp;
                    }
                }

                if (temp == null)
                {
                    isSorted = true;
                }
            }
        }

        public void NextGeneration()
        {
            generationNum++;

            Chromosome[] newPopulation = new Chromosome[POP_SIZE];
            for (int i = 0; i < POP_SIZE; i++)
            {
                newPopulation[i] = new Chromosome(imageToMatch.Width * imageToMatch.Height);
            }


            for (int i = 0; i < eleitism; i++) // eleitism
            {
                newPopulation[i] = population[i];
            }

            for (int i = eleitism; i < POP_SIZE - 1; i += 2)
            {
                int num1 = population[0].prng.Next(0, POP_SIZE / 2);
                int num2 = population[0].prng.Next(0, POP_SIZE / 2);
                while (num1 == num2)
                {
                    num2 = population[0].prng.Next(0, POP_SIZE / 2);
                }
                Chromosome child1, child2;

                population[num1].Mate(population[num2], out child1, out child2);

                newPopulation[i] = child1;
                newPopulation[i + 1] = child2;
            }

            //newPopulation[POP_SIZE - 1] = new Chromosome(population[0]);
            //
            //for (int i = 0; i < population[POP_SIZE - 1].GetChromosomeLength(); i++)
            //{
            //    newPopulation[POP_SIZE - 1].MutateGeneAtIndex(i, 10);
            //}
            population = new Chromosome[POP_SIZE];
            population = newPopulation;

            CalcFitnesses();
        }

        public Bitmap GetBestCitizen()
        {
            Bitmap image = new Bitmap(imageToMatch.Width, imageToMatch.Height);

            int colorVal;

            for (int i = 0; i < population[0].GetChromosomeLength(); i++)
            {
                colorVal = population[0].GetGeneByIndex(i).GeneColor;
                image.SetPixel(i % imageToMatch.Width, i / imageToMatch.Width, Color.FromArgb(colorVal, colorVal, colorVal));
            }
            return image;
        }

        public int GetBestCitizenFitness()
        {
            return population[0].Fitness;
        }
    }
}
