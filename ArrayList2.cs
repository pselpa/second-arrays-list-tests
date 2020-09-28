using System;

namespace second_arrays_list_tests
{
    class ArrayList2
    {
        public (int[], int[]) Exercise1(int[] arrayA, int[] arrayB)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1, então a aplicação deverá 
            //receber dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores
            
            var temp = new int[10];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = arrayA[i];
                arrayA[i] = arrayB[i];
                arrayB[i] = temp[i];
            }
            return (arrayA, arrayB);
        }


        public bool Exercise2(int[] array)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2, então a aplicação deverá 
            //receber um vetor com 10 valores. Após esta operação, informe se há ou não números repetidos nesse vetor.
            
            bool result = false;
            Array.Sort(array);

            int previousNumber = Int32.MaxValue;  
            foreach (int item in array)
            {
                if (item == previousNumber)
                {
                    result = true;
                    break;
                }
                previousNumber = item;
            }
            return result;
        }


        // public (double, double, double, double) Exercise3()
        // {
        //     //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3, então a aplicação deverá receber o sexo do entrevistado 
        //     //e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
        //     //O número de pessoas que responderam sim;
        //     //O número de pessoas que responderam não;
        //     //A percentagem de pessoas do sexo feminino que responderam sim;
        //     //A percentagem de pessoas do sexo masculino que responderam não;
        // }


        public double Exercise4(double[] arrayA)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4, então a aplicação deverá 
            //receber uma matriz A do tipo vetor e Apresentar a soma de todos os elementos que sejam impares

            double sumOddNumbers = 0;

            foreach (var item in arrayA)
            {
                if (item % 2 != 0)
                {
                    sumOddNumbers += item;
                }
            }
            return sumOddNumbers;
        }


        public double Exercise5(double[] array)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5, então a aplicação deverá
            //retornar quantos valores de um vetor de 10 posições são positivos

            int evenNumbersCount = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0 && item != 0)
                {
                    evenNumbersCount++;
                }
            }
            return evenNumbersCount;
        }

        
        public (double, int) Exercise6(double[] array)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 6, então a aplicação deverá receber
            //um vetor de 10 números positivos e escrever o valor do maior elemento e a respectiva posição que ele ocupa no vetor.

            double biggestValue = 0;
            int index = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestValue)
                    {
                        biggestValue = array[i];
                        index = i;
                    }
            }
            return (biggestValue, index);
        }


        public int Exercise7(double[] arrayA)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 7, então a aplicação deverá receber
            //um vetor A e imprimir na tela quantas vezes há um número residindo na mesma posição do vetor que seu valor numérico.

            int indexCount = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] == i)
                {
                    indexCount++;
                }                       
            }
            return indexCount;
        }


        public int Exercise8(string[] arrayAlphabet)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 8, então a aplicação deverá receber
            //um vetor A e imprimir na tela quantas vezes há um número residindo na mesma posição do vetor que seu valor numérico.

            int vowelCount = 0;

            foreach (var item in arrayAlphabet)
            {
                if (item == "A" || item == "a" || item == "E" || item == "e" || item == "I" || item == "i" || item == "O" || item == "o" || item == "U" || item == "u")
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }


        public string Exercise9(string[] arrayAlphabet)
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 9, então a aplicação deverá receber um vetor de strings de 10
            //posições onde cada uma recebe uma letra do alfabeto. Imprima a string resultante da soma das strings que residem em índices pares
        
            string evenNuberIndexString = "";

            for (int i = 0; i < arrayAlphabet.Length; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    evenNuberIndexString += arrayAlphabet[i];
                }
            }                    
            return evenNuberIndexString;
        }
    }
}