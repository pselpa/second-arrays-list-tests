using Xunit;

namespace second_arrays_list_tests
{
    public class ArrayList2Tests
    {
        [Theory]
        [InlineData(new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, new int[10]{11, 12, 13, 14, 15, 16, 17, 18, 19, 20}, new int[10]{11, 12, 13, 14, 15, 16, 17, 18, 19, 20}, new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        public void Should_return_two_arrays_which_had_its_content_switched(int[] arrayA, int[] arrayB, int[] expectedA, int[] expectedB)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            (int[], int[]) returnedValue = exercises.Exercise1(arrayA, arrayB);

            // Deve / Asserções
            Assert.Equal(expectedA, returnedValue.Item1);
            Assert.Equal(expectedB, returnedValue.Item2);
        }


        [Theory]
        [InlineData(new int[10]{5, 6, 7, 22, 3, 74, 35, 69, 82, 45}, false)]
        [InlineData(new int[10]{12, 9, 4, 5, 81, 63, 74, 59, 5, 32}, true)]
        public void Should_return_if_there_is_any_repeated_number(int[] array, bool expected)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            bool returnedValue = exercises.Exercise2(array);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new double[5]{4, 22, 31, 17, 5}, 53)]
        [InlineData(new double[3]{-5, 12, 17}, 12)]
        [InlineData(new double[5]{13, 27, 14, 36, 11}, 51)]
        [InlineData(new double[4]{-5, 0, 131, 40}, 126)]
        public void Should_return_the_sum_of_odd_numbers_of_an_array(double[] arrayA, double expected)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            double returnedValue = exercises.Exercise4(arrayA);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new double[5]{-10, 12, 4, 31, 67}, 3)]
        [InlineData(new double[6]{1, 87, 96, 24, 56, 21}, 3)]
        [InlineData(new double[10]{15, 63, 22, 48, 97, 102, 0, 69, 82, 56}, 5)]
        [InlineData(new double[7]{4, 56, 0, -78, 93, 24, 53}, 4)]
        public void Should_return_the_amount_of_even_numbers_in_an_array(double[] array, double expected)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            double returnedValue = exercises.Exercise5(array);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }


        [Theory]
        [InlineData(new double[5]{24, 32, 16, 74, 89}, 89, 4)]
        [InlineData(new double[6]{51, 87, 132, 54, 98, 13}, 132, 2)]
        [InlineData(new double[7]{87, 52, 31, 49, 23, 347, 18}, 347, 5)]
        public void should_return_the_biggest_number_in_an_array_and_its_index(double[] array, double expectedValue, int expectedIndex)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            (double, int) returnedValue = exercises.Exercise6(array);

            // Deve / Asserções
            Assert.Equal(expectedValue, returnedValue.Item1);
            Assert.Equal(expectedIndex, returnedValue.Item2);
        }


        [Theory]
        [InlineData(new double[5]{14, 1, 5, 78, 4}, 2)]
        [InlineData(new double[10]{0, 45, 69, 87, 22, 3, 4, 56, 8, 9}, 3)]
        [InlineData(new double[6]{5, 6, 32, 17, 48, 9}, 0)]
        [InlineData(new double[5]{-5, 67, 2, 34, 5}, 1)]
        public void should_return_how_many_times_a_number_was_equal_its_index(double[] arrayA, int expectedValue)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            int returnedValue = exercises.Exercise7(arrayA);

            // Deve / Asserções
            Assert.Equal(expectedValue, returnedValue);
        }


        [Theory]
        [InlineData(new string[5]{"a", "g", "b", "e", "m"}, 2)]
        [InlineData(new string[5]{"h", "e", "i", "o", "z"}, 3)]
        [InlineData(new string[5]{"k", "n", "p", "r", "y"}, 0)]
        [InlineData(new string[5]{"c", "ç", "f", "t", "u"}, 1)]
        public void should_return_the_amount_of_vowels_in_the_array(string[] arrayAlphabet, int expectedValue)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            int returnedValue = exercises.Exercise8(arrayAlphabet);

            // Deve / Asserções
            Assert.Equal(expectedValue, returnedValue);
        }


        [Theory]
        [InlineData(new string[7]{"a", "e", "k", "l", "c", "s", "h"}, "kch")]
        [InlineData(new string[7]{"s", "u", "m", "t", "r", "y", "e"}, "mre")]
        [InlineData(new string[7]{"n", "j", "w", "s", "d", "r", "l"}, "wdl")]
        [InlineData(new string[7]{"h", "v", "g", "e", "r", "ç", "f"}, "grf")]
        public void should_return_the_result_word_with_the_even_indexes_in_the_array(string[] arrayAlphabet, string expectedValue)
        {
            // Dado / Setup
            var exercises = new ArrayList2();

            // Quando / Ação
            string returnedValue = exercises.Exercise9(arrayAlphabet);

            // Deve / Asserções
            Assert.Equal(expectedValue, returnedValue);
        }


        [Theory]

    }
}
