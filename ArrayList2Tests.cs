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
    }
}
