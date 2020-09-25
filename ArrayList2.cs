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


        public (double, double, double, double) Exercise3()
        {
            //Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3, então a aplicação deverá receber o sexo do entrevistado 
            //e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
            //O número de pessoas que responderam sim;
            //O número de pessoas que responderam não;
            //A percentagem de pessoas do sexo feminino que responderam sim;
            //A percentagem de pessoas do sexo masculino que responderam não;

            
        
        
        }
            
    }
}