namespace Lab5
{
    public static class Tasks
    {
        /// <summary>
        /// Удалить все элементы с нечетными номерами.
        /// </summary>
        /// <param name="array">Одномерный массив</param>
        /// <returns>Отфильтрованный одномерный массив</returns>
        public static int[] FilterArray(int[] array)
        {
            var filteredArray = new int[array.Length / 2];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    filteredArray[j] = array[i];
                    j++;
                }
            }
            return filteredArray;
        }

        /// <summary>
        /// Добавить К столбцов в начало матрицы.
        /// </summary>
        /// <param name="table">Двумерный массив</param>
        /// <param name="k">Кол-во стоблцов</param>
        /// <returns>Расширенный двумерный массив</returns>
        public static int[,] ExtendTable(int[,] table, uint k)
        {
            var extendedTable = new int[table.GetLength(0), table.GetLength(1) + k];
            for (var rowIndex = 0; rowIndex < table.GetLength(0); rowIndex++)
                for (var columnIndex = 0; columnIndex < table.GetLength(1); columnIndex++)
                    extendedTable[rowIndex, columnIndex + k] = table[rowIndex, columnIndex];
            return extendedTable;
        }

        /// <summary>
        /// Удалить все строки с четными номерами.
        /// </summary>
        /// <param name="jagArray">Рваный массив</param>
        /// <returns>Отфильтрованный рваный массив</returns>
        public static int[][] FilterJagArray(int[][] jagArray)
        {
            var filteredJagArray = new int[jagArray.Length / 2 + jagArray.Length % 2][];
            for (var rowIndex = 0; rowIndex < jagArray.Length; rowIndex += 2)
                filteredJagArray[rowIndex / 2] = jagArray[rowIndex];
            return filteredJagArray;
        }
    }
}